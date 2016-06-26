# NightPatcher

[Downloads](https://github.com/OatmealDome/SplatoonUtilities/releases/tag/NightPatcher) | [Splatoon Modding Hub](http://gbatemp.net/threads/splatoon-modding-hub.425670/)

NightPatcher is a utility that automatically patches MapInfo.byaml to force "Splatfest mode" for all multiplayer maps, regardless if there is a Splatfest active at the moment. There is one known bug: The Splatfest intro and one minute remaining music will play; however, the battle BGM will be randomized as normal.

If you wish to exclude certain maps from the patch, open up NightPatcher.py with Notepad (or your favourite text editor). You will find a list of all the multiplayer maps' internal and "common" names. To exclude a stage, add a \# symbol to the beginning of the line.

This is my first time programming in Python. Please be gentle :P

**You will be banned if you use this online. I do not take any responsibility if Nintendo does ban you.**

## Usage

### Prerequisites

* [Python 3.4 or above](https://www.python.org/downloads/)
* [cafiine_server](https://github.com/MrRean/Cafiine-410-551/blob/master/server/cafiine_server.exe)
* A game dump of Splatoon (use ddd; make sure the dump is the latest version)

### Instructions

1. Download the latest release of NightPatcher from the link above.
2. Copy Static.pack from vol/content/Pack into the same folder as NightPatcher.
3. Double click NightPatcher.py and wait for the script to finish.
4. Create a folder for cafiine_server and place the executable inside it.
5. Create the following folder structure inside the above folder: cafiine_root/[title id]/vol/content/Pack. See below for a list of title IDs and an example.
6. Copy Static_night.pack from the NightPatcher folder into cafiine_root/[title id]/vol/content/Pack.
7. Rename Static_night.pack to Static.pack.
8. Run cafiine_server.exe.
9. On your Wii U, go to http://loadiine.ovh, select "Cafiine + Kernel" from the list, press the green checkmark button and follow the instructions.
10. In the cafiine installer, set the IP to your computer's local IP and install cafiine.
11. Launch Splatoon.
12. All multiplayer stages should now take place at night. You can confirm this by entering Recon.

### Title ID list

- North America: 00050000-10176900
- Europe: 00050000-10176A00
- Japan: 00050000-10162B00

Example structure for North America:

<img src="http://i.imgur.com/d5v4MWb.png" />

## Credits

* Kinnay, MrRean, RoadrunnerWM: for byml.py ([original repository](https://github.com/MrRean/Splat3D))
* NWPlayer123: for SARCTools ([original repository](https://github.com/NWPlayer123/WiiUTools/tree/master/SARCTools)) and for starting Splatoon's modding "scene"
* RenolY2: for cleaning up and updating sarc-extract ([original repository](https://github.com/RenolY2/sarc-extract))
