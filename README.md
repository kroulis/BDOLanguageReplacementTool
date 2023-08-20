# BDO Language File Replacement Tool (Beta 2)

This tool helps you to replace the default localization file of an installed Black Desert Online Client with another localization file (that could be from a different Server's Client). The tool currently supports:
- NAEU Server
- SEA Server
- TW Server
- JP Server
- RU Server
- TR Server
- SA Server
- Global Lab Server

The tool currently does not support:
- Korea Server

## How to use this tool
Please refer to the main branch's document!

## How to join the beta 2 test
Before `Dec 1, 2023 00:00:00 AM UTC`, you can use input the following invite code to the tool:
```
KjsxNzAxNDE3NjAwIzY5MkUyMUM5RDQ1Qzc1NzM1ODE4MkM1MUMwNkE0NENBNzc5NTkxNEQxOUI4OTIwRDA4Njc2NzE5QjhDMjMxRjIyQTBEMjI1NDNBRjQ2NUU1REFENkJGOTkxNzU5M0ExREQ3NDMyM0Y1MjQ5NUJDOEI0Nzk4MDI2RDBDQzk0QTg1NkU0QzM4MDBGMDBBMUM5MjJDNUZGQTgwNEZDRDFDNzcxQzZGRjU3OTc2NEQ5RTc5OTlCQUUwODM1MDNDOTkxMUY5OTBEQUFBOEM2ODBEQzZFODVCQTA0MjVGMjk0ODdBQzJENEE4REM0NEY2QkI2NENFRTQzRkExMTUzQjkxODI=
```
After the above date, please contact the repo owner directly for invite code!

## How to activate the scripting editing feature
First download the prebuild binary in the beta branch.

Go through the original method to select the source language and the target language.

In the advance panel, click the `Script Editor` button, type in the invite code and press activate.

If your invite code is valid, you are now having access to the in testing feature. 

## What to test for:
1. Test if the scripting feature is working intended:
	+ Create/Modify/Execute a local script
	+ Execute an online script. The demo scripts are at:
		- https://raw.githubusercontent.com/kroulis/BDOLanguageReplacementTool/beta/official/scripts/merge.yml
		- https://raw.githubusercontent.com/kroulis/BDOLanguageReplacementTool/beta/official/scripts/twcn2zhcn.yml
		- https://raw.githubusercontent.com/kroulis/BDOLanguageReplacementTool/beta/official/scripts/twcnwithfix.yml
2. Provide us any suggestion you are thinking off.

## Changes in Beta 2
Moved the script editing tool to the advance tab.  
Added a simplified way to execute scripts through the `Language File Replacement` tab.
Fixed a few bugs from the beta 1:
 + Fixed the refresh button text in the scripting tool
 + Fixed an issue that loading remote script that contains non english words through URL given unreadable random characters.

Improved some localizations.  
Added a new warning for font installing such that if it cannot find the BDO's config file (most likely due to the game is never opened), it will warn the user that the font installation might not work.

## Functionalities added in Beta 1
Added the scripting feature that allows you to execute a script to modify the language files. This script can be edited by the tool's embedded graphical editor.

A few sample scripts have been provided in this test for demonstration purpose:
+ A script to merge two different localization files.
+ A script to merge a language (tested with NAEU server) with TW_CN language.
+ A script to merge a language (tested with NAEU server) with ZH_CN language.

## Issues
If you found any bug in this software, you can submit issues freely. I will regularly check the repo.

## Other information
Chinese version of this document is at **[HERE](doc/README_ZH_CN.md)**
