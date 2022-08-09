<img src="assets/images/readmebanner.png"/>

#### https://github.com/o7q/cubeLauncher
#### Welcome! cubeLauncher is a simple, lightweight installation manager for Minecraft. I originally made this tool for me and my friends but now you can use it too!

<br>

# Overview
This tool works like CurseForge except it is inside of a single executable file without the need of an installer. It creates its own launcher profile within the Minecraft launcher preventing it from interfering with any previous installations.

The options menu includes several features that allow you to change the settings for the installation, such as the name, arguments, resolution, etc.

To use the config features simply use the "Save Config" and "Load Config" buttons. Doing this will save/load the specified options to a config file specific to the selected installation. \
Using the "Override Config" option will globally override any saved configs.

<br>

Using and creating config files manually can be accomplished by following these steps:
1. Inside of the directory for the installation, create a folder called ".cube"
2. Inside of the ".cube" folder, create a file called "config.cube"
3. Inside of the "config.cube" file, paste the following code:
```
# CUBELAUNCHER OVERRIDE CONFIG
name: 
version: 
width: 
height: 
arguments: 
modloader: 
```

<br>

If you would like a modloader such as forge or fabric to auto install when installing a folder you can specify it under the "modloader" argument inside "config.cube". \
Place the installer file alongside "config.cube" and specify the name of that file after "modloader: ".

<br>

## <b>Components</b>
<b>Drag & Drop a Folder Window:</b> Dragging a folder here will install and then search for modloaders for the dropped folder \
<b>Installation Selection Dropdown:</b> Selects an installation to be launched \
<b>Create Installation Button:</b> Create a blank installation \
<b>Delete Installation Button:</b> Deletes the selected installation \
<b>Open Installation Directory Button:</b> Opens the directory for the selected installation \
<b>Options Button:</b> Opens options window \
<b>Launch Button:</b> Launches the selected installation with the specified arguments \
<b>Name Input:</b> Minecraft launcher name \
<b>Version Input:</b> Minecraft launcher version \
<b>Resolution Input:</b> Minecraft launcher resolution \
<b>Arguments Input:</b> Minecraft launcher arguments \
<b>Select MC Launcher Path Directory Button:</b> Specify an alternate path for the Minecraft Launcher \
<b>Clear MC Launcher Path Directory Button:</b> Resets the Minecraft Launcher path to default

<br>

<img src="assets/images/v160/v160.png"/> \
<img src="assets/images/v160/v160_2.png"/>

<br>

Running C# .NET Framework 4.8. \
If you want to compile the code yourself I highly recommend using Visual Studio.