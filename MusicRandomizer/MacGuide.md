# Using MusicRandomizer with macOS

MusicRandomizer is written in C# and uses the .NET framework, which is Windows-only. However, we can use a program called [Wine](https://en.wikipedia.org/wiki/Wine_(software)) to run these types of programs on non-Windows operating systems.

**This guide is unfinished, so please do not follow the steps listed here for now.**    

## Instructions

### Prerequisites

* [WineBottler](http://winebottler.kronenberg.org/)

### Using WineBottler

1. Download the development version of WineBottler from the link above.
2. Copy both applications ("Wine" and "WineBottler") from the disk image to your Applications folder.
3. Open WineBottler and go to the "Advanced" tab.
4. Under "Program Installation", click the "Select File" button and select the MusicRandomizer.exe file.
5. Under "Installation Mode", select "copy file (Program) to the App Bundle".
6. Under "System Version Info", change the dropdown box to say "7".
7. Uncheck "open-source .NET framework" and "open-source MSHTML implementation".
8. Next to "Dll Overrides", type in "mscoree.dll".
9. In "Winetricks", check the boxes next to "dotnet452" and "corefonts".
10. Check the box next to "Silent Install".
11. Click Install and save the Application somewhere. This may take a while. Additionally, if windows start opening and closing rapidly, do not panic: that is normal behaviour.


### Starting the Application

1. When the installation is complete, open up the application. The first launch may take a few minutes to complete. Once finished, the MusicRandomizer main window will appear.
