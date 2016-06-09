# MusicRandomizer

[Downloads](https://github.com/OatmealDome/SplatoonUtilities/releases/tag/MusicRandomizer) | [Splatoon Modding Hub](http://gbatemp.net/threads/splatoon-modding-hub.425670/)

<img src="http://i.imgur.com/PnaL55y.jpg" width="53%" height="53%"/> <img src="http://i.imgur.com/AKXKPkZ.png" width="40%" height="40%" />

MusicRandomizer is a modified Cafiine server that replaces Splatoon's music with custom tracks in a randomized order. It has the ability to replace one track like the matchmaking theme (Ika Jamaica) with multiple different tracks. Normally, you would only be able to replace Ika Jamaica with one single track!

Additionally, MusicRandomizer functions as a normal Cafiine server, so you can use other file replacement hacks like forced night mode simulataniously. (Unfortunately, because Cafiine and TCPGecko cannot be combined at this time, you cannot use hacks like octohax at the same time as MusicRandomizer.)

If you wish to mute the music altogether, there is a file called Silent.bfstm included in the package. You can import this file and set it so that certain sections of the game (ex Multiplayer matches) will have no music at all.

**Custom music is safe to use online at this time. However, if it becomes unsafe in the future, I do not take any responsibility if you are banned.**

## Usage

### Prerequisites

* Windows (Mac and Linux users, use Wine or Mono)
* [.NET Framework 4.5.2](http://go.microsoft.com/fwlink/?LinkId=328843)
* Music in the BFSTM format (You can get these from places like [Smash Custom Music](http://smashcustommusic.com). You can even create them yourself. See below for more information.)
* [Your local IP address](http://windows.microsoft.com/en-ca/windows/find-computers-ip-address#1TC=windows-7)

### Instructions

1. Copy MusicRandomizer.exe from the .zip to an empty folder on your computer.
2. Double click MusicRandomizer.exe to start it.
3. Import your music files and choose when they should play.
4. (optional) Add other file replacement hacks into the "other_files" folder.
5. On your Wii U, go to http://loadiine.ovh.
6. Select "Cafiine + Kernel" from the list and press the green checkmark button.
7. When the browser exits, immediately go back to loadiine.ovh to launch the Cafiine installer.
8. At the black screen, enter your computer's local IP address using the D-Pad and press A when finished.
9. Launch Splatoon.
10. The tracks you added should now replace the in-game music.

## Creating .BFSTMs

You can create music files in the BFSTM format by using various other programs.

* [Looping Audio Converter](http://www.lakora.us/brawl/loopingaudioconverter/) by libertyernie
* [BRSTM/BCSTM/BFSTM Conversion Tool](https://gbatemp.net/threads/release-brstm-bcstm-conversion-tool-beta.378702/) by nastys

Please note:

* Songs will have to have loop settings when converted to be able to repeat in-game.
* Some tracks (like the Shop music) **must** be multi-stream, otherwise they may not sound correct in-game.
* On the other hand, all tracks listed in the Import dialog **must not** be multi-stream, otherwise they may not sound correct in-game.

## Troubleshooting

1. Splatoon hangs on the splash screen with the drums playing
   * There are two possible causes:
     * The Wii U cannot connect to the Cafiine server running on your computer.
     * There is an issue with a file in the "other_files" folder that caused the game to hang.
   * Did you enter the right IP address?
   * Is MusicRandomizer running?
   * Have you tried turning off your firewall?
   * If there are files in the "other_files" folder, verify their integrity.

2. Sometimes the music "skips" or "pauses" briefly
   * This can be indicative of network or computer lag. 
   * Is anyone else on the network downloading files, watching videos, or other bandwidth-heavy activities?
   * Is the computer running MusicRandomizer doing computationally intensive tasks like playing a video game?
