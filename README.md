# BDO Language File Replacement Tool (Beta 1)

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

## How to join the beta 1 test
Before `June 1, 2023 00:00:00 AM UTC`, you can use input the following invite code to the tool:
```
KjsxNjg1NjAyODAwIzNGQjkwQTcyOENDMUFFMDgwRjYyQTEyNDhCRURBRUZCQzU0MkI1NTgxMjRGNzE3MDkyMjhBQjM3MkE5QkY1OEZCRjlGQUREN0FBMkIwOThBMzVFMjVGOTIyMURENzZBNzBDM0M0NUVCNTNFRURBNDUwOTAxOTFGRTZGRTVGQjExMzIwQzk4NkYxNEM1RDNGNkVDN0IwMzdDMUM5RUVBQjc3NDAxMUMwQkZDQzQyRjE2MjJERTlGQ0Y5NERGQkM1Q0M2RTkyRjhFODFCMDA2MDY2QzIwMzc5OUE2MzgzRjdGREU0ODYwNERERDQyOTZEMEZCMzIzOTI2NzFDRUQ4Rjg=
```
After the above date, please contact the repo owner directly for invite code!

## How to activate the scripting feature
First download the prebuild binary in the beta branch.

Go through the original method to select the source language and the target language.

Click the `Script` button, type in the invite code and press activate.

If your invite code is valid, you are now having access to the in testing feature. 

## What to test for:
1. Test if the scripting feature is working intended:
	+ Create/Modify/Execute a local script
	+ Execute an online script. The demo scripts are at:
		- https://raw.githubusercontent.com/kroulis/BDOLanguageReplacementTool/beta/official/scripts/merge.yml
		- https://raw.githubusercontent.com/kroulis/BDOLanguageReplacementTool/beta/official/scripts/twcn2zhcn.yml
		- https://raw.githubusercontent.com/kroulis/BDOLanguageReplacementTool/beta/official/scripts/twcnwithfix.yml
2. Provide us any suggestion you are thinking off.

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
