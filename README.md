# WWHDR Config Transfer
*A very simple dotnet app to tranfer various files for [the Wind Waker HD randomizer](https://github.com/SuperDude88/TWWHD-Randomizer)*

## Installing 
Follow the steps for both Wii U and PC:
* Wii U : Install the [FTPiiU plugin](https://github.com/wiiu-env/ftpiiu_plugin/releases/tag/v0.4.4) (note: you can also install this through the homebrew appstore and the aroma updater). Optionnaly, for patching game files, enable the "Allow access to system files" option in the config menu of FTPiiU (L + DPAD DOWN + MINUS will open the plugin menu -> navigate to the FTPiiU plugin)

* PC : Simply download [the latest release](https://github.com/Teotia444/WWHDR-Config-loader/releases/latest) and keep it somewhere where you can find it. The EXE file won't generate additionnal files, so you can keep it on your desktop for example

## Using
### Basic uses (tranfering config, preferences, plando file...)
* **Make sure the app from which the transfer tool will send the file has been closed at least once after having made your settings before using this app! Otherwise, your config might not save properly** 
* **Make sure the app that will be recieving the config file is closed! Otherwise, your config might not load properly**
* *Example : For sending a config file from your computer to your Wii U, you should have closed the PC rando app at least once after having made your settings (so that the files gets saved properly) AND you should have closed the Wii U rando app and not reopen it before the config transfer tool has done its job*
* Using FTPiiU, find the local IP address of the Wii U (L + DPAD DOWN + MINUS will open the plugin menu -> navigate to the FTPiiU plugin). It should look something like :
```
192.168.XXX.XXX (with the X being different numbers)
Ex : 192.168.1.13 could show up on your screen (its probably not gonna be the case)
```
Note it down somewhere
* On your computer, inside the config transfer app, enter the IP address in the "Wii U IP Address textbox. You should also locate the desktop app (the wwhd_rando.exe) and an optionnal plandomizer file. Make sure the IP address is correct by clicking the "Check" button. If it isnt, you probably typed out the wrong numbers.
* Either click the PC -> Wii U button to transfer from your computer to your Wii U, or the Wii U -> PC button to transfer from your computer to your Wii U

### Advanced uses (Spoiler logs, file replacement...)
* *You need the IP address to be already set up for this section!*
#### Using the spoiler log view 
* You can fetch either the Wii U logs or the PC logs using both buttons on the bottom. Make sure to click one of them, otherwise no spoilers log will show up. 
* The logs are chronologically sorted, so open the top one to open the latest seed's spoiler log.
#### Using the file patcher view : 
* **Disclaimer** : The file patcher tab allows you to modify game files, and will directly modify NAND/USB files. Always double check you're not messing with the wrong files before adding patches! As long as the files are correct, nothing will be messed up.
* For patching game files, enable the "Allow access to system files" option in the config menu of FTPiiU (L + DPAD DOWN + MINUS will open the plugin menu -> navigate to the FTPiiU plugin)
* Select the game install medium, then add new patches. First, enter the path from the game's root folder (e.g. /Content/Common/Misc/Misc.szs). Then select the corresponding file on your computer.
* If the program looks like it hangs for a while when patching files, just wait. You are probably sending a large file.
* You can enable and disable any patches you want, send only one at a time or send all of the patches you selected.