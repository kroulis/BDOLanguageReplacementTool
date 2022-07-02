using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDOLangReplacement.Localizations
{
    public class LocalizationENUS : Localization
    {
        public LocalizationENUS()
        {
            APPTitle = "BDOLanguageReplacementTool";
            BDONotFound1 = "Cannot find the Black Desert Online Launcher. Do you want to manually select the BDO root folder?\n" +
                           "If choose NO: please put this executable to the root folder of the Black Desert Online.";
            BDONotFound2 = "Invalid root folder of Black Desert Online. Do you want to retry?\n" +
                           "If choose NO: please put this executable to the root folder of the Black Desert Online.";
            BDONotFoundDialogTitle = "Error";
            BDOFolderSelectionDescription = "Select the root folder of the Black Desert Online";
            Tab1Name = "Language Versions";
            Tab2Name = "Language File Replacement";
            Tab3Name = "Fonts Setup";
            Tab4Name = "About";
            Tab1LabelText = "Double click on the language file you want to replace to:";
            Tab1LangUnavailableDialogText = "This language file is unavailable at this moment. Please refresh or report to the author.";
            Tab1LangUnavailableDialogTitle = "Unable to load the language file.";
            Tab1RefreshBtnText = "Refresh";
            Tab1LangVersionInvalid = "Unavailable";
            Tab1RefreshLog1 = "Refresh Process returned with such exception:\n";
            Tab1RefreshLog2 = "Please contact the author or create an issue on the github.";
            Tab1RefreshLogTitle = "Warning";
            Tab1DefaultReplacement1 = "You recently selected to replace to ";
            Tab1DefaultReplacement2 = ". Do you want to replace it?";
            Tab1DefaultReplacementTitle = "Found default replacement language";
            Tab2GameLanguage = "Select your current language in game:";
            Tab2ReplacementLanguage = "You are proposed to change to:";
            Tab2IsSteam = "Is your game launched from Steam?";
            Tab2SteamCheckBox = "From Steam";
            Tab2StartLaunchBtnText = "Start Launcher";
            Tab2ReplaceBtnText = "Replace";
            Tab2RecoverBtnText = "Restore";
            Tab3CNFontBtnText = "Install OR Remove pearl.ttf";
            Tab3FontStatus = "Font Status:";
            Tab3FontInstalled = "Installed";
            Tab3FontMissing = "Not Found";
            Tab3FontTypeSimplifiedChinese = "Simplified Chinese";
            Tab3FontTypeTraditionalChinese = "Traditional Chinese";
            Tab4AboutText = "This tool is made by Kroulis. You can replace you language file freely with this tool. " +
                "This tool is proudly open sourced with MIT licence. You can check it out in GitHub using the link below. Have fun!";
            FailedToInstallCNFont = "Failed to install the CN Font.";
            FailedToInstallCNFontTitle = "Error";
            BDOLauncherFound = "Found BDO Launcher...";
            BDOLauncherNotFound = "Cannot find BDO Launcher Process. Please start the game Launcher before replacing or restoring the localization file.";
            NewVersionAvailable = "Tool current version {0}, Online version {1}. \r\nDo you want to go to the repo to download the new version?";
        }
    }
}
