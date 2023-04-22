# BDO Language File Replacement Tool [![Build Status](https://github.com/kroulis/BDOLanguageReplacementTool/actions/workflows/dotnet.yml/badge.svg)](https://github.com/kroulis/BDOLanguageReplacementTool/actions/workflows/dotnet.yml) [![Unit Test](https://github.com/kroulis/BDOLanguageReplacementTool/actions/workflows/unit_test.yml/badge.svg)](https://github.com/kroulis/BDOLanguageReplacementTool/actions/workflows/unit_test.yml)

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
1. Either clone this repo and compile the code using visual studio or download a prebuild executable **directly** from this github repo.
    - Make sure to check the MD5/SHA1 of the executable after downloading the prebuild executable.
	- The code is tested to be able to build using automation tools with a Visual Studio 2019 Community Edition. 
2. Either put this tool in the root folder of the BDO or you will have to manually select the BDO root folder.
3. Wait until the tool to finish grabbing the most recent localization file version data before performing proceeding the following.
4. Double click the language file you want to replace to.
5. Choose the default language of your current game client.
6. Start the BDO launcher either from the tool or on your own. (Notice that if you purchased the game from steam, make sure the corresponding checkbox is checked)
7. Login to the BDO launcher and wait for the update to finish.
8. Click the Replace button in the tool.
9. Start the game.
10. Happy gaming!

## Cache system

The tool saves your last operation by memorizing the source language type and the target language type. So once you completed step 4 to 8 one time, the next time the tool will directly select it for you, and you just need to do step 6 to 8.

## Functionalities added in 1.1
1. Added a simple solution to fix missing phrases from a localization file by using the original language file's phrases. Missing phrases will be showing in korean or just blank in game. This solution is shown as the `Merge` in the `Language File Replacement` tab.
2. Added functions to decrypt, encrypt, diff, merge localization files. This part is added to the `Advance` tab. (For accessing this portion, you need to download the other repo's executable. The download and install is embedded to this tool to provide ease of access. If you are curious about the helper tool, please see [kroulis/BDOLangReplacementToolHelper](https://github.com/kroulis/BDOLangReplacementToolHelper))


## Special thanks

Special thanks to this **[Reddit Post](https://www.reddit.com/r/blackdesertonline/comments/p8vjss/guide_all_your_bdo_language_file_needs/)**.

## Issues
If you found any bug in this software, you can submit issues freely. I will regularly check the repo.

## Other information
Chinese version of this document is at **[HERE](doc/README_ZH_CN.md)**
