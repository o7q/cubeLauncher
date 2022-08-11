<img src="assets/images/readmebanner.png"/>

#### https://github.com/o7q/cubeLauncher/releases
### Welcome! cubeLauncher is a simple, lightweight installation manager for Minecraft. I originally made this tool for me and my friends but now you can use it too!

<br>

<img src="assets/images/program.png"/>

<br>

# Overview
This tool works like CurseForge except it is inside of a single executable file without the need of an installer. It creates its own launcher profile within the Minecraft launcher preventing it from interfering with any previous installations.

Using and creating config files manually can be accomplished by following these steps:
1. Inside of the directory for the installation, create a folder called `.cube`
2. Inside of the `.cube` folder, create a file called `config.cube`
3. Inside of the `config.cube` file, paste the following code:
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

If you would like a modloader such as forge or fabric to auto install when installing a folder you can specify it under the `modloader` argument inside `config.cube`. \
Place the installer file alongside `config.cube` and specify the name of that file after `modloader: `.

<br>

## <b>Components</b>
<b>Drag & Drop a Folder Window</b> Dragging a folder here will install and then search for modloaders for the dropped folder \
<b>Installation Selection Dropdown</b> Selects an installation to be launched \
<b>Create Installation Button</b> Create a blank installation \
<b>Delete Installation Button</b> Deletes the selected installation \
<b>Open Installation Directory Button</b> Opens the directory for the selected installation \
<b>Options Button</b> Opens the options window \
<b>Launch Button</b> Launches the selected installation with the specified arguments \
<b>Name Input</b> Minecraft launcher name \
<b>Version Input</b> Minecraft launcher version \
<b>Resolution Input</b> Minecraft launcher resolution \
<b>Arguments Input</b> Minecraft launcher arguments \
<b>Select MC Launcher</b> Path Button Specify an alternate path for the Minecraft Launcher \
<b>Clear MC Launcher</b> Path Directory Button Resets the Minecraft Launcher path to default

<br>

Running C# .NET Framework 4.8. \
If you want to compile the code yourself I highly recommend using Visual Studio.