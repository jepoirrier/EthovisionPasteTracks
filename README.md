# EthovisionPasteTracks (EPT), a tool to easily export bitmap tracks from Ethovision

## Introduction

EthoVision (from [Noldus](http://www.noldus.com/)) is a software that allows tracking of moving animals in a defined area. It's useful in the Morris water maze or the Open Field, for example. When preparing a presentation, an article or simply to show some results to your colleagues, you sometimes need to export the representation of the path taken by your animal.

In Ethovision, there is a direct way to export the representations of all the paths (done by one animal, during one session, for example). The problem is that you need to type in the directory and filename for each file. When you have 60 times 17 files to save, this become a labor intensive, repetitive and error prone process.

Fortunately, Ethovision allows us to copy each of these tracks to the Windows clipboard. You can then manually export tracks (with Photoshop, for example) but it's still labor intensive.

The goal of EPT is to get track representations from the clipboard (put there by Ethovision) and to automatically save the serie of images while incrementing a value in their filename.

Features:

* Works with Ethovision version 3.x (not tested with other versions)
* Gets bitmap tracks from the clipboard and automatically saves it in a PNG file
* Allows to specify the base directory (where all the images will be stored), a filename prefix, a start number for the serie
* Automatically increments a value in the image filename
* Can also be used to store any other bitmap from clipboard

These Windows keyboard shortcuts allows you to become more productive:

* Ctrl + c = copy selected track in Ethovision to the clipboard
* Ctrl + v = paste the track in the clipboard in EthovisionPasteTracks
* Alt + Tab = quickly switch between Ethovision and EthovisionPasteTracks (hold Alt key while switching between many applications with successive hit on the Tab key).

## Screenshots

Ethovision Past Tracks screenshots can be found in the screenshots/ directory.

##Software

Download the latest version of EPT from the bin/ directory.

The directory gives you all required files, including the executable (the software you'll use). You can run this software under MS-Windows, provided you have the .Net framework. If you regularly update your computer, you should already have it. Anyway, you can download it from Microsoft and install it.

This software is released under the GNU General Public Licence (GPL): C#/.Net source code is in the src/ directory.

Copyright (C) belongs to Jean-Etienne Poirrier, 2006-2016. You can contact me at jepoirrier "at" gmail.com.

Please report if you have any problem, comment or if you would like new features in this software.

## Usage

The software is so simple that there should be no problem to use it ... When you launch EthovisionPasteTracks, you need to specify three values:

* the base directory: this is where all the images will be stored. You can type in directly the directory in the box or you can click on the small button on the right to choose the right directory with your mouse. If there is an error, the default directory is your personal directory.
* the subject number or filename prefix: if you choose "mwm124-test", for example, all you files will be named "mwm124-test1.png", "mwm124-test2.png", "mwm124-test3.png", etc.
* the start number: usually, a serie begins at "1" but you can choose your own start number.

In Ethovision, in your workspace, choose to visualise the tracks (menu Experiment -> "Visualize Data" or use this icon: icon). If needed, select the tracks you need (menu Data -> "Select Tracks" or Ctrl + T or this small icon: icon). You can adjust the way your tracks appear in the menu View.

* Select one track, the border should become highlighted (in our lab, it's in red). Copy this track to the clipboard (menu Edit -> Cut or Ctrl + C).
* Come back in EthovisionPasteTracks and paste your bitmap (it will automatically save the complete file). Note that the "Preview" panel doesn't show your whole image (but the saved one will contain everything).
* Repeat the two previous steps with each of your tracks.

You can also watch this short video demonstrating how to use it with Ethovision. In this video, the export of tracks is not done exactly in the same order but the result is the same.

<a href="http://www.youtube.com/watch?feature=player_embedded&v=E04g8pUKZ-I" target="_blank"><img src="http://img.youtube.com/vi/E04g8pUKZ-I/0.jpg" alt="Ethovision Paste Tracks" width="240" height="180" border="10" /></a>

If you are using Ethovision, you might be interested in another small tool from me: [Ethovision Missing Samples](https://github.com/jepoirrier/EthovisionMissingSamples).
