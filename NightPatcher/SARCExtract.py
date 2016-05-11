#
# Made by NWPlayer123, no rights reserved, feel free to do whatever
#

"""
The MIT License (MIT)

Copyright (c) 2015 RenolY2

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

"""

import os
import sys
import struct

try:
    xrange(10)
except NameError:
    # In Python 3, xrange does not exist anymore.
    # Python 2's xrange is the same as Python 3's range, so we define it as such.
    def xrange(*args):
        return range(*args)


def uint8(data, pos):
    return struct.unpack(">B", data[pos:pos + 1])[0]


def uint16(data, pos):
    return struct.unpack(">H", data[pos:pos + 2])[0]


def uint32(data, pos):
    return struct.unpack(">I", data[pos:pos + 4])[0]


def check(length, size, percent, count):
    length = float(length)
    size = float(size)

    test = round(length / size, 2)  # Percent complete as decimal
    test *= 100  # Percent

    if test % count == 0:
        if percent != test:  # New Number
            print(str(test)[:-2] + "%")
            percent = test

    return percent


def get_str(data):
    x = data.find(0x00)
    if x != -1:
        return data[:x]
    else:
        return data


def yaz0_decompress(data):
    # Thanks to thakis for yaz0dec, which I modeled this on after
    # I cleaned it up in v0.2, what with bit-manipulation and looping
    # Thanks to Kinnay for suggestions to make this even faster
    print("Decompressing Yaz0....")

    pos = 16
    size = uint32(data, 4)  # Uncompressed filesize
    out = []
    out_len = 0

    dstpos = 0
    percent = 0
    bits = 0
    code = 0

    if len(data) >= 5242880:
        count = 5  # 5MB is gonna take a while
    else:
        count = 10

    while len(out) < size:  # Read Entire File
        percent = check(out_len, size, percent, count)

        if bits == 0:
            code = uint8(data, pos)
            pos += 1
            bits = 8

        if (code & 0x80) != 0:  # Copy 1 Byte
            out.append(data[pos])
            pos += 1
            out_len += 1

        else:
            rle = uint16(data, pos)
            pos += 2

            dist = rle & 0xFFF
            dstpos = len(out) - (dist + 1)
            read = (rle >> 12)

            if (rle >> 12) == 0:
                read = ord(data[pos]) + 0x12
                pos += 1
            else:
                read += 2

            for x in xrange(read):
                out.append(out[dstpos + x])
                out_len += 1

        code <<= 1
        bits -= 1

    out = "".join(out)

    return out


def sarc_extract(data, mode):
    print("Reading SARC...")
    pos = 6

    name, ext = "Static_night", "pack" # *** Modified by OatmealDome ***

    if mode == 1:  # Don"t need to check again with normal SARC
        magic1 = data[0:4]

        if magic1 != "SARC":
            print("Not a SARC Archive!")
            print("Writing Decompressed File....")

            with open(name + ".bin", "wb") as f:
                f.write(data)

            print("Done!")

    # Byte Order Mark
    order = uint16(data, pos)
    pos += 6

    if order != 65279:  # 0xFEFF - Big Endian
        print("Little endian not supported!")
        sys.exit(1)

    # Start of data section
    doff = uint32(data, pos)
    pos += 8

    # ---------------------------------------------------------------

    magic2 = data[pos:pos + 4]
    pos += 6

    assert magic2 == b"SFAT"

    # Node Count
    node_count = uint16(data, pos)
    pos += 6

    nodes = []

    print("Reading File Attribute Table...")

    for x in xrange(node_count):
        pos += 8

        # File Offset Start
        srt = uint32(data, pos)
        pos += 4

        # File Offset End
        end = uint32(data, pos)
        pos += 4

        nodes.append([srt, end])

    # ---------------------------------------------------------------
    magic3 = data[pos:pos + 4]
    pos += 8

    assert magic3 == b"SFNT"
    strings = []

    print("Reading file names....")
    no_names = 0

    if get_str(data[pos:]) == "":
        print("No file names found....")
        no_names = 1

        for x in xrange(node_count):
            strings.append("bfbin" + str(x) + ".bfbin")

    else:
        for x in xrange(node_count):
            string = get_str(data[pos:]).decode("utf-8")
            pos += len(string)

            while data[pos] == 0:
                pos += 1  # Move to the next string

            strings.append(string)

    # ---------------------------------------------------------------
    print("Writing Files....")

    try:
        os.mkdir(name)
    except OSError:
        print("Folder already exists, continuing....")

    if no_names:
        print("No names found. Trying to guess the file names...")

    flim_count = 0
    flan_count = 0
    flyt_count = 0

    for x in xrange(node_count):
        filename = os.path.join(name, strings[x])

        if not os.path.exists(os.path.dirname(filename)):
            os.makedirs(os.path.dirname(filename))

        start, end = (doff + nodes[x][0]), (doff + nodes[x][1])
        filedata = data[start:end]

        if no_names:
            if filedata[-0x28:-0x24] == b"FLIM":
                filename = name + "/" + "bflim" + str(flim_count) + ".bflim"
                flim_count += 1

            if filedata[0:4] == b"FLAN":
                filename = name + "/" + "bflan" + str(flan_count) + ".bflan"
                flan_count += 1

            elif filedata[0:4] == b"FLYT":
                filename = name + "/" + "bflyt" + str(flyt_count) + ".bflyt"
                flyt_count += 1

        #print(filename)

        with open(filename, "wb") as f:
            f.write(filedata)

    print("Extraction complete.")


def main():
    print("SARCExtract v0.4 by NWPlayer123")
    print("Thanks to Kinnay and thakis")

    if len(sys.argv) != 2:
        print("Usage: SARCExtract archive.szs")
        sys.exit(1)

    with open(sys.argv[1], "rb") as f:
        data = f.read()

    magic = data[0:4]

    if magic == "Yaz0":
        decompressed = yaz0_decompress(data)
        sarc_extract(decompressed, 1)

    elif magic == "SARC":
        sarc_extract(data, 0)

    else:
        print("Unknown File Format: First 4 bytes of file must be Yaz0 or SARC")
        sys.exit(1)

if __name__ == "__main__":
    main()