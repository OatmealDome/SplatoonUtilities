"""

Copyright (c) 2016 OatmealDome

Permission is hereby granted, free of charge, to any person obtaining a
copy of this software and associated documentation files (the "Software"),
to deal in the Software without restriction, including without limitation
the rights to use, copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit persons to whom the Software
is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.


=======

Special shoutouts to Kinnay, MrRean, RoadrunnerWM for byml.py (the first byaml
"editor" that worked for me), to NWPlayer123 (because I did not want to write
my own SARC extractor and compressor), and to RenolY2 (for cleaning up sarc-
extract).

=======

"""

import byml, errno, os, SARCExtract, SARCPack, shutil, sys

# This array contains the internal names for all of the multiplayer maps.
# If you don't want a specific map to be in night mode, add a # symbol at
# the beginning of the line.
toPatch = [
"Fld_Office00_Vss", # Ancho-V Games
"Fld_UpDown00_Vss",  # Arowana Mall
"Fld_SkatePark00_Vss", # Blackbelly Skatepark
"Fld_Ruins00_Vss", # Bluefin Depot
"Fld_Athletic00_Vss", # Camp TriggerFish
"Fld_Jyoheki00_Vss", # Flounder Heights
"Fld_Kaisou00_Vss", # Hammerhead Bridge
"Fld_Maze00_Vss", # Kelp Dome
"Fld_Hiagari00_Vss", # Mahi-Mahi Resort
"Fld_Tuzura00_Vss", # Moray Towers
"Fld_Pivot00_Vss", # Museum d'Alfonsino
"Fld_Quarry00_Vss", # Piranha Pit
"Fld_Amida00_Vss", # Port Mackerel
"Fld_SeaPlant00_Vss", # Saltspray Rig
"Fld_Crank00_Vss", # Urchin Underpass
"Fld_Warehouse00_Vss", # Walleye Warehouse
]

def main():
        # Make sure we're running in at least Python 3
        if sys.version_info[0] < 3 or (sys.version_info[0] == 3 and sys.version_info[1] < 4):
                print("This script must be run with Python 3.4+.\n")
                if raw_input:
                        raw_input("Press enter to exit.")
                else:
                        input("Press enter to exit.")
                return

        # If the Static_night/ directory exists, get rid of it
        try:
                shutil.rmtree("Static_night")
                print("Removed Static_night/ directory.")
        except OSError as error:
                if error.errno != errno.ENOENT:
                        raise

        # If Static_night.pack exists, get rid of it
        try:
                os.remove("Static_night.pack")
                print("Removed existing Static_night.pack.")
        except OSError as error:
                if error.errno != errno.ENOENT:
                        raise
        
        # Decompress and extract the SARC archive
        print("Decompressing Static.pack...")
        try:
                with open("Static.pack", "rb") as archiveFile:
                        archiveData = archiveFile.read()
        except IOError:
                print("An error occurred while reading Static.pack. Does the file exist in the same directory as this script?")
                return

        SARCExtract.sarc_extract(archiveData, 0)

        # Read MapInfo into a byml object
        print("Reading MapInfo.byaml...")
        with open("Static_night/Mush/MapInfo.byaml", "rb") as mapInfoFile:
                mapInfoData = mapInfoFile.read()

        mapInfo = byml.BYML(mapInfoData)

        # Iterate over all entries...
        for map in mapInfo.rootNode:
                # and if the map matches one of the 16 online multiplayer maps...
                if map["MapFileName"] in toPatch:
                        # then patch Brightness and EnvHour
                        print("Patching " + map["MapFileName"] + "...")
                        map.getSubNode("Brightness").changeValue("Dark")
                        map.getSubNode("EnvHour").changeValue("Night")
                #elif map["MapFileName"] == "Fld_Plaza00_Plz":
                        # ** This does not work:
                        #
                        # Brightness -> Dark = does nothing(?)
                        # EnvHour -> Night = crashes the game
                        # SceneEnvSetName -> blank = does nothing(?)
                        #
                        #print("Patching Fld_Plaza00_Plz (custom)...")
                        #map.getSubNode("Brightness").changeValue("Dark")
                        #map.getSubNode("EnvHour").changeValue("Night")
                        #map.getSubNode("SceneEnvSetName").changeValue("")
                        
                        
        mapInfo.saveChanges()

        # Remove the original MapInfo.byaml
        print("Removing the original MapInfo.byaml...")
        os.remove("Static_night/Mush/MapInfo.byaml")

        # Write out a new MapInfo.byaml containing the modified data
        with open("Static_night/Mush/MapInfo.byaml", "wb") as newOutput:
                print("Writing new MapInfo.byaml...")
                newOutput.write(mapInfo.data)

        # Compress the Static_night/ directory into a new SARC file
        print("Recompressing Static_night/...")
        newArchive = SARCPack.SimpleArchive()
        newArchive.pack("Static_night", 0x100)
        os.rename("Static_night.sarc", "Static_night.pack")
        
        # Clean up
        print("Cleaning up...")
        shutil.rmtree("Static_night")

        print("Patching complete.\n")
        print("For usage information, go to https://github.com/OatmealDome/SplatUtilities/")
        print("and click NightPatcher.\n")

        input("Press enter to exit.")

if __name__ == "__main__":
    main()
