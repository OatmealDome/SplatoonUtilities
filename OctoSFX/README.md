# OctoSFX

This mod was made by bkool999 and replaces specific Inkling Girl sound effects with Octoling sound effects. 

**OctoSFX is safe to use online at the time when this guide was written.**

## Usage

### Prerequisites

* a Wii U on an exploitable firmware (4.1.0 to 5.5.1)
* Homebrew Launcher 
* Python 2.7
* a cafiine server (examples: [the original by Chadderz and MrRean](https://github.com/MrRean/Cafiine-410-551/blob/master/server/cafiine_server.exe), [MusicRandomizer](https://github.com/OatmealDome/SplatoonUtilities/blob/master/MusicRandomizer/README.md), [Ray's custom server](https://github.com/Syroot/CafiineServer), and more)

### Setting up a cafiine server

If you already have a cafiine server running on your computer, you can skip this section.

1. Create a new folder for the server, download [cafiine_server.exe](https://github.com/MrRean/Cafiine-410-551/blob/master/server/cafiine_server.exe), and put the file inside it.
2. Create the folders ```cafiine_root``` and ```logs``` inside the folder for cafiine server.
3. Start the server to ensure that it works. If it is, there will be a message saying "```listening on port 7332```".
4. Set a static IP address for your computer. Click [here](https://github.com/OatmealDome/SplatoonUtilities/blob/master/Misc/StaticIPGuide.md) for more information.

### Installing OctoSFX

1. Download the latest version of OctoSFX from [the video description](https://www.youtube.com/watch?v=6DNnK5h4KMQ). Downloading ```Player.pack``` is not necessary.
2. In ```cafiine_root```, create the following folder structure: ```[title id]/vol/content/Pack```. Replace ```[title id]``` with the one associated with your Splatoon region (see below).
3. Copy ```Sound.pack``` to the ```Pack``` folder. 

### Preparing the AIO

1. Download the [AIO](https://raw.githubusercontent.com/seresaa/Splat-AIO/master/Splat-AIO.zip) and extract its contents into a folder.
2. Find your Wii U's IP address. Click [here](https://github.com/OatmealDome/SplatoonUtilities/blob/master/Misc/FindingWiiUIP.md) for more information.
3. Start the AIO by double clicking on Splat-AIO.py.
4. Type in in your Wii U's IP address and press enter. You should be looking at a menu screen.

### Installing geckiine

1. There are two possible ways to get a geckiine.elf file with your IP address.

   a. Go to [466gaming.ga/geckiine](http://466gaming.ga/geckiine) and enter in your IP address. Click the download button and extract the ZIP file

   b. Download ```geckiine.zip``` with Geckiine Creator from [here](https://github.com/seresaa/geckiine-creator/releases/tag/v0.1) and extract it. Run ```Geckiine Creator.exe```, enter in your IP address into the four boxes and click the "Create/Patch ELF" button.
3. Copy the ```geckiine``` folder to the ```wiiu/apps``` folder on your SD card.
4. Remove your SD card and insert it into the Wii U.

### Starting Splatoon

1. Ensure that the cafiine server is running and that Splat-AIO is waiting on the menu screen.
2. Go to [loadiine.ovh](http://loadiine.ovh) and start the Homebrew Launcher.
3. From the list of applications, tap on geckiine and press Start. You will be returned to the Wii U menu.
4. Start Splatoon. Due to the slow transfer rate of cafiine and the largeness of the ```Sound.pack``` file (~58MB), your Wii U may hang for a while on the splash screen with the drums playing. This is normal.
5. On [the loading screen with the squids swimming towards the top](http://33.media.tumblr.com/fbe13f9f0ed194113ed449f9dbcad00b/tumblr_nt4jr35e291thqzumo1_500.gif), type in "1" into the AIO menu if you want the regular squid form or "2" if you want the broken octopus form. Press enter after typing in a number.
6. You're now an Octoling with the proper sound effects!

You will need to re-do this section every time you want to play Splatoon as an Octoling with the proper sound effects.

## Troubleshooting

* The Wii U hangs when returning to the Wii U menu
    - This happens when the cafiine client on the Wii U isn't able to make a connection to the cafiine server on your computer.
    - Did you enter in the right IP on [466gaming.ga/geckiine](http://466gaming.ga/geckiine)?
    - If you didn't set a static IP, did your IP address change? If so, you will need to redo the "Installing geckiine" section. It is highly recommended that you set a static IP.
    - Try turning off your firewall.

* Splatoon hangs on the splash screen with the drums playing
    - This is normal behaviour, unless it has been 15+ minutes since you started Splatoon.
    - Try restarting the Wii U and re-doing the "Starting Splatoon" section.
    - Does anything appear in the cafiine server log about ```Sound.pack```? Is there an associated ```fclose()``` message with that log message? If there isn't, cafiine is probably still transferring the file. Try waiting a little bit longer.

## Title ID List

- North America: 00050000-10176900
- Europe: 00050000-10176A00
- Japan: 00050000-10162B00

Example structure for North America:

<img src="http://i.imgur.com/d5v4MWb.png" />

## Credits

* bkool999 for creating OctoSFX
* seresaa for being quality control
* NWPlayer123 for Octohax
* PhantoCrystal for helping out
* amibu for also helping out
* OatmealDome for writing the guide and releasing geckiine
