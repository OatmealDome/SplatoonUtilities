# Language Switching

[Other Utilities](https://github.com/OatmealDome/SplatoonUtilities/) | [Splatoon Modding Hub](http://gbatemp.net/threads/splatoon-modding-hub.425670/)

This guide will help you change your current language to a different one.

**Language switching is safe to use online at this time. However, if it becomes unsafe in the future, I do not take any responsibility if you are banned.**

## Instructions

### Prerequisites

* [Uwizard](https://gbatemp.net/threads/uwizard-all-in-one-wii-u-pc-program.386508/) (or any other program that can download from NUS and decrypt the contents)
* [The Wii U common key](https://google.com/search?q=Wii+U+Common+Key)
* [cafiine_server](https://github.com/MrRean/Cafiine-410-551/blob/master/server/cafiine_server.exe)
* [Your local IP address](http://windows.microsoft.com/en-ca/windows/find-computers-ip-address#1TC=windows-7)

### Downloading the language files

1. Please look at "Languages" below to see what region you need to download from. 
2. Download Uwizard and extract it into an empty folder.
3. Open Uwizard and go to the "Settings" tab.
4. Paste the Wii U's common key into the box dedicated for it. If it is correct, then the text next to the text box will turn green.
5. Go to the "NUS Downloader U" tab.
6. Enter in the title ID (see below), changing the last 0 before the dash to an E, leaving out the dash, and adding a 0 to the end. (example for North America: ```0005000E101769000```) Leave the version number text box blank, as this will force Uwizard to download the latest version. You will need to keep the ```.szs``` files you download up-to-date, otherwise some text may be missing or the game may crash if a new update is released.
8. Click "Start Download" and wait. Once it is finished, Windows Explorer will pop up with the newly downloaded and decrypted files.

### Replacing the language files

1. Download cafiine_server and place it into an empty folder.
2. Create the following folder structures inside the above folder (the title ID you enter here is **not** the one for Uwizard, but rather the title ID of your copy of Splatoon):


   - ```cafiine_root/[your copy's title ID]/vol/content/Font```
   - ```cafiine_root/[your copy's title ID]/vol/content/Message```
   - ```logs/```


3. Copy the only file in ```nus_content/[Uwizard title ID]/vol/content/Font``` to the Font folder in ```cafiine_root```.
4. Rename it to ```BmpFont_[region code].szs```, where "region code" is your current copy's region code (see below).
5. Copy ```nus_content/[Uwizard title ID]/vol/content/Message/CommonMsg_[target language code].szs``` to the Message folder in cafiine_root, where "target language code" is the code of the language you want to change to.
6. Rename the above file, replacing the language code with the one which your copy of Splatoon is currently running in.
7. Repeat steps 5 and 6 for ```LayoutMsg_[target language code].szs```.

### Using cafiine

1. Start cafiine_server.exe.
2. On your Wii U, go to http://loadiine.ovh.
3. Select "Cafiine + Kernel" from the list and press the green checkmark button.
4. When the browser exits, immediately go back to loadiine.ovh to launch the Cafiine installer.
5. At the black screen, enter your computer's local IP address using the D-Pad and press A when finished.
6. Launch Splatoon.
7. Splatoon should now be in your target language.

### Examples

These examples are provided in case the above instructions aren't clear enough. 

In the following scenario, I want to change the language from Canadian French to Japanese.

* download using title ID ```0005000E10162B000``` (Japan) in Uwizard
* create cafiine file structure using title ID ```00050000-10176900``` (North America)
* copy ```BmpFont_JP.szs``` from Uwizard → ```BmpFont_US.szs``` in cafiine
* copy ```CommonMsg_JPja.szs``` from Uwizard → ```CommonMsg_USfr.szs``` in cafiine
* copy ```LayoutMsg_JPja.szs``` from Uwizard → ```LayoutMsg_USfr.szs``` in cafiine

In the next scenario, I want to change the language from German to American English.

* download using title ID ```0005000E101769000``` (North America) in Uwizard
* create cafiine file structure using title ID ```00050000-10176A00``` (Europe)
* copy ```BmpFont_US.szs``` from Uwizard → ```BmpFont_EU.szs``` in cafiine
* copy ```CommonMsg_USen.szs``` from Uwizard → ```CommonMsg_EUde.szs``` in cafiine
* copy ```LayoutMsg_USen.szs``` from Uwizard → ```LayoutMsg_EUde.szs``` in cafiine

## Languages

This is a list of the different versions of Splatoon and which language files they contain. The title ID as well as the region code is listed next to each header for each region's copy. Language codes are listed next to the names of the languages.

- North America (```00050000-10176900```, US)

   These are translations by the Treehouse from Nintendo of America.

    * American English (USen)
    * Canadian French (USfr)
    * Spanish (USes)
    
- Europe (```00050000-10176A00```, EU)

   These are translations by Nintendo of Europe.
   
   * British English (EUen)
   * French (EUfr)
   * Spanish (EUes)
   * German (EUde)
   * Italian (EUit)
   
- Japan (```00050000-10162B00```, JP)

   This is the source text for all translations.

   * Japan (JPja)
   
## Credits

* amiibu for doing language switching before me
* KapuDaKoopa for inspiration

