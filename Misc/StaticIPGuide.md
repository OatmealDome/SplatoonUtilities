# Setting up a Static IP

Having a static IP means that your computer's IP will never change. This is especially useful for geckiine, where the IP address is currently hardcoded into the binary. It also makes installing things like cafiine more convenient, since your computer's IP will never change and you will never have to look it up again.

This guide will help you set up a static IP for your computer. There are two methods: through your router, and through your computer's operating system. The router method is preferred so you don't have to keep changing settings every time you connect to a different network.

## Router Method

Unfortunately, because all routers are different, I cannot provide specific instructions on how to setup a static IP. I recommend that you Google the brand name of your router, the model number, and "static IP". If you cannot find anything, try looking in your router's web interface for keywords such as "DHCP", "static IP", and "network".

## Computer Method

The steps here will depend on which operating system you have. Please note that if you connect your computer to a different network, you may have to remove the static IP settings as they may not work for the network you have connected to.

### Windows

1. In the notifications tray (usually on the bottom right), right click on the network icon. (It's either a wireless signal strength icon or a picture of a monitor with an Ethernet cable)
2. In the context menu that pops up, click "Network and Sharing Center".
3. Click on "Change adapter settings" in the left side bar.
4. Right click on your active Internet connection (usually "Wireless Network Connection" for Wi-Fi and "Local Area Network" for Ethernet) and click Status.
5. In the dialog that pops up, click "Details".
6. Make note of your "IPv4 Address", "IPv4 Subnet Mask", and your "IPv4 Default Gateway" in the window that pops up.
7. Click "Close" to exit the Details dialog.
8. Click "Properties" in the Status dialog.
9. Find "Internet Protocol Version 4 (TCP/IPv4)", click on it, and click the "Properties" button.
10. Check the box next to "Use the following IP address".
11. Enter the information you took note of earlier into the boxes.
12. In the box "Preferred DNS server", type in ```8.8.8.8```. (This IP and the one below are Google's public DNS servers.)
13. In the box "Alternate DNS server", type in ```8.8.4.4```.
14. Dismiss all dialogs by clicking "OK" or "Close".

To remove the settings:

1. Follow steps 1 to 9 above, making note of your settings.
2. Check the box "Obtain an IP automatically".
3. Dismiss all dialogs by clicking "OK" or "Close".
4. When you reconnect to your normal network where your Wii U is located, follow the steps above (excluding steps 5 to 7) to re-add the settings.

### macOS

1. Go to the Apple logo in the menu bar and click "System Preferences".
2. Open the "Network" pane.
3. Select your current Internet connection (either "Wi-Fi" or "Ethernet") in the left side bar.
4. Note down all settings listed. ("IP Address", "Subnet Mask", and "Router")
5. Next to "Location", change the dropdown box from "Automatic" to "Edit Locations".
6. Click the plus button to add a new location and name it "Wii U".
7. Select the location, click "Done", and then click "Apply" in the lower right. Your Mac will temporarily disconnect from the Internet and reconnect. (Wi-Fi users, if you aren't automatically connected back to your Wi-Fi, manually connect to your network from the wireless icon in the menu bar.)
8. Select your current Internet connection (either "Wi-Fi" or "Ethernet") in the left side bar.
9. Change the dropdown box next to "Configure IPv4" to "Manually".
10. Enter in the settings that you noted above into the boxes and click "Apply". Your Mac will once again temporarily disconnect from the Internet and reconnect.
11. Quit System Preferences.

To remove the settings:

1. Follow steps 1 and 2 above.
2. Next to "Location", change the dropdown box to "Automatic".
3. Click "Apply" in the lower right corner.
4. When you reconnect to your normal network where your Wii U is located, simply change the location dropdown box back to "Wii U".

### Linux

I can't help you here, since there are many different varieties Linux out there. Try Googling the name of your distribution (ex Ubuntu), the name of your current GUI (ex GNOME), and "static IP".
