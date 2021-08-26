# HAZESHOCK (Unity)

A first person shooter developed on Unity Engine. The project files work in Unity version 2020.3.2f1 or higher. 

The open beta is out now for free! Download from here: (or install it from this project in HAZESHOCK/Installer/HAZESHOCK Setup x86.exe)
https://metalrave.itch.io/hazeshock (available only for Windows, yet!)

## Description
The premise of the game is to shoot and kill as many enemies as possible, which will spawn randomly in the arena. The player gets damaged if he collides with any of the enemies.
You can use a rifle and a pistol, and even punch while holding the pistol. You can heal yourself when your low on health with the floating health boxes. The enemies come in waves, with each wave having an increase in number and in their difficulty level. 

## Level Design
The project is based on the Universal Render Pipeline with some post processing effects. The majority of level is modeled using Unity's ProBuilder Tool from scratch. The disceted enemy objects are made using Blender. The rifle model (orignally made by Brackeys) is optimised with a lot of light bars in Unity itself. The rest of the objects are made using Unity's primitive 3D objects and materials.

## Lighting and Graphics
The scene had a baked (i.e the lighting system is prerendered, which provides better performance as compared to realtime lighting) lightmap consisting of numerous Light emmitter materials, with a slight directional lighting. 
The scene also has a lot of light probes and a reflection probe to made it look realistic. 

The post-processing effects include HDR, Bloom, Depth of Field, Colour Correction and Shawdows

## Animations
All the animations are created inside Unity's Animation Tab from scratch. All of them are stored in /HAZESHOCK/Assets/Animations

## Scripting
All Scripts are coded in C#, and are located in: HAZESHOCK/Assets/Scripts


Note: This project takes currently about 2.5 gigabytes of space.

This is the first open beta version of the game so you might experience some bugs or crashes, which'll get fixed in some time. I'll also be constantly adding new features and updates so any feedback from you is appreciated!

