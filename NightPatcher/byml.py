"""
Copyright (C) 2015-2016 Kinnay, MrRean, RoadrunnerWMC
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
1. Redistributions of source code must retain the above copyright
notice, this list of conditions and the following disclaimer.
2. Redistributions in binary form must reproduce the above copyright
notice, this list of conditions and the following disclaimer in the
documentation and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY Yannik Marchand ''AS IS'' AND ANY
EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL Yannik Marchand BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

The views and conclusions contained in the software and documentation 
are those of the authors and should not be interpreted as representing
official policies, either expressed or implied, of Yannik Marchand.
"""

import struct

def String(data,offs):
    return data[offs:].split(b'\0')[0].decode('shift-jis')

def UI24(data,offs):
    return struct.unpack('>I',b'\x00'+data[offs:offs+3])[0]

def UI32(data,offs):
    return struct.unpack_from('>I',data,offs)[0]

class ValueNode:
    def __init__(self,v,offs,byml):
        self.val = v
        self.offs = offs
        self.byml = byml

    def __str__(self):
        return str(self.val)

    def parse(self):
        pass

class StringNode(ValueNode):
    def changeValue(self,val):
        self.val = str(val)
        self.byml.stringChanged(self)

class BooleanNode(ValueNode):
    def changeValue(self,val):
        self.val = bool(val)
        bchar = b'\x01' if self.val else b'\x00'
        self.byml.data = self.byml.data[:self.offs]+bchar+self.byml.data[self.offs+1:]

class IntegerNode(ValueNode):
    def changeValue(self,val):
        self.val = int(val)
        self.byml.data = self.byml.data[:self.offs]+struct.pack('>i',self.val)+self.byml.data[self.offs+4:]

class FloatNode(ValueNode):
    def changeValue(self,val):
        self.val = float(val)
        self.byml.data = self.byml.data[:self.offs]+struct.pack('>f',self.val)+self.byml.data[self.offs+4:]

class NoneNode(ValueNode):
    pass

class DictNode:
    def __init__(self,offs,byml):
        self.parsed = False
        self.offs = offs
        self.dict = {}
        self.byml = byml

    def __iter__(self):
        return iter(self.subNodes())

    def parse(self):
        if self.parsed:
            return

        offs = self.offs
        data = self.byml.data
        count = UI24(data,offs)
        offs+=3

        for i in range(count):
            name = UI24(data,offs)
            nodetype = data[offs+3]
            value = UI32(data,offs+4)
            offs+=8

            sname = self.byml.nodes[name]
            if nodetype == 0xA0:
                self.dict[sname] = StringNode(self.byml.strings[value],offs-4,self.byml)
            elif nodetype == 0xC0:
                self.dict[sname] = ArrayNode(value+1,self.byml)
            elif nodetype == 0xC1:
                self.dict[sname] = DictNode(value+1,self.byml)
            elif nodetype == 0xD0:
                s = True if value else False
                self.dict[sname] = BooleanNode(s,offs-4,self.byml)
            elif nodetype == 0xD1:
                if value>0x80000000:
                    value-=0x100000000
                self.dict[sname] = IntegerNode(value,offs-4,self.byml)
            elif nodetype == 0xD2:
                v = struct.unpack('>f',struct.pack('>I',value))[0]
                self.dict[sname] = FloatNode(v,offs-4,self.byml)
            elif nodetype == 0xFF:
                self.dict[sname] = NoneNode(None,offs-8,self.byml)
            else:
                raise ValueError("Unknown Dictionary Node Type: "+hex(nodetype))

        self.parsed = True

    def __getitem__(self,name):
        node = self.getSubNode(name)
        if isinstance(node,ValueNode):
            return node.val
        return node

    def getSubNode(self,name):
        if not name in self.dict:
            raise ValueError("Dictionary has no sub node named "+str(name))

        self.dict[name].parse()
        return self.dict[name]

    def getSubValue(self,name):
        node = self.getSubNode(name)
        if not isinstance(node,ValueNode):
            raise TypeError("Diction sub node is not a value node")
        return node.val

    def subNodes(self):
        for obj in self.dict.values():
            obj.parse()
        return self.dict

class ArrayNode:
    def __init__(self,offs,byml):
        self.parsed = False
        self.offs = offs
        self.array = []
        self.byml = byml

    def __getitem__(self,name):
        node = self.getSubNode(name)
        if isinstance(node,ValueNode):
            return node.val
        return node    

    def __len__(self):
        return len(self.array)

    def __iter__(self):
        return iter(self.subNodes())

    def parse(self):
        if self.parsed:
            return
        
        offs = self.offs
        data = self.byml.data
        count = UI24(data,offs)
        offs+=3
        
        types = []
        for i in range(count):
            types.append(data[offs])
            offs+=1
            
        if offs%4:
            offs+=4-(offs%4)
            
        offsets = []
        for i in range(count):
            offsets.append([offs,UI32(data,offs)])
            offs+=4
            
        for i in range(count):
            type = types[i]
            offs = offsets[i]
            if type == 0xA0:
                self.array.append(StringNode(self.byml.strings[offs[1]],offs[0]),self.byml)
            elif type == 0xC1:
                self.array.append(DictNode(offs[1]+1,self.byml))
            else:
                raise ValueError("Unknown array node type: "+hex(type))

        self.parsed = True

    def subNodes(self):
        for obj in self.array:
            obj.parse()
        return self.array

class BYML:
    def __init__(self,data):
        self.data = data
        assert data[:2] == b'BY'
        self.offs1 = UI32(data,4)
        self.offs2 = UI32(data,8)
        self.offs3 = UI32(data,12)
        self.nodes = []
        self.strings = []
        self.doStringTable(self.offs1,self.nodes)
        self.stringEnd = self.doStringTable(self.offs2,self.strings)
        self.stringUpdates = []
        self.rootNode = self.getRootNode(self.offs3)
        self.rootNode.parse()

    def doStringTable(self,offs,l):
        soffs = offs
        assert self.data[offs] == 0xC2
        count = UI24(self.data,offs+1)
        offs+=4
        for i in range(count):
            l.append(String(self.data,soffs+UI32(self.data,offs)))
            offs+=4
        return offs

    def getRootNode(self,offs):
        type = self.data[offs]
        if type == 0xC0:
            node = ArrayNode(offs+1,self)
        elif type == 0xC1:
            node = DictNode(offs+1,self)
        else:
            raise ValueError('Unknown Section Type: '+hex(type))
        return node

    def stringChanged(self,node):
        if not node in self.stringUpdates:
            self.stringUpdates.append(node)

    def saveChanges(self):
        for node in self.stringUpdates:
            if node.val not in self.strings:
                self.strings.append(node.val)
                self.offs3 += 4
                self.data = self.data[:self.stringEnd]+struct.pack('>I',len(self.data))+self.data[self.stringEnd:]
                self.data += node.val+b'\x00'
            self.data = self.data[:node.offs]+struct.pack('>I',self.strings.index(node.val))+self.data[node.offs+4:]

        self.data = self.data[:12]+struct.pack('>I',self.offs3)+self.data[16:]
        self.data = self.data[:self.offs2+1]+struct.pack('>I',len(self.strings))[1:]+self.data[self.offs2+4:]

        self.stringUpdates = []
