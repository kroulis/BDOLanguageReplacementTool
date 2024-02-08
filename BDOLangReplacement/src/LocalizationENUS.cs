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
            APPTitle = "BDOLocalizationFileReplacementTool";
            BDONotFound1 = "Cannot find the Black Desert Online Launcher. Do you want to manually select the BDO root folder?\n" +
                           "If choose NO: please put this executable to the root folder of the Black Desert Online.";
            BDONotFound2 = "Invalid root folder of Black Desert Online. Do you want to retry?\n" +
                           "If choose NO: please put this executable to the root folder of the Black Desert Online.";
            BDONotFoundDialogTitle = "Error";
            BDOFolderSelectionDescription = "Select the root folder of the Black Desert Online";
            Tab1Name = "Language Versions";
            Tab2Name = "Language File Replacement";
            Tab3Name = "Advanced";
            Tab4Name = "Fonts Setup";
            Tab5Name = "About";
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
            Tab2AdvancedText = "Advanced";
            Tab2MergeBtnText = "Merge";
            Tab2ScriptBtnText = "Scripts";
            Tab3HelperToolStatusText = "HelperTool Status";
            Tab3HelperToolLocalVersionText = "Local Version:";
            Tab3HelperToolOnlineVersionText = "Online Version:";
            Tab3HelperToolVersionUnavailable = "Not Found";
            Tab3InstallUpdateHelperToolBtnText = "Install/Update";
            Tab3UninstallHelperToolBtnText = "Uninstall";
            Tab3AdvancedOperationGroupText = "Advance Operations";
            Tab3AdvancedOpCodeLabelText = "Operation:";
            Tab3AdvancedOpSrcFileLabelText = "Source:";
            Tab3AdvancedOpOutFileLabelText = "Output:";
            Tab3AdvancedOpAddtionalFile1Text = "Additional1:";
            Tab3AdvancedOpAddtionalFile2Text = "Additional2:";
            Tab3AdvancedOpExecuteBtnText = "Execute";
            Tab3AdvancedOpBrowseBtnText = "Browse";
            Tab3AdvancedOpCodeSelectBoxItems = "Decrypt\nEncrypt\nDiff\nMerge\nTranslate(Traditional Chinese to Simplified Chinese)\nReplace\nRename\nRemove";
            Tab3InstallHelperToolFirstText = "Tool not found. Please install the tool first!";
            Tab4CNFontBtnText = "Install OR Remove pearl.ttf";
            Tab4FontStatus = "Font Status:";
            Tab4FontInstalled = "Installed";
            Tab4FontMissing = "Not Found";
            Tab4FontTypeSimplifiedChinese = "Simplified Chinese";
            Tab4FontTypeTraditionalChinese = "Traditional Chinese";
            Tab4EmbeddedFontText = "Embedded Fonts";
            Tab4CustomFontText = "Custom Font";
            Tab4CustomFontBoxText = "Select Custom Font to Install:";
            Tab4BrowseFontBtnText = "Browse Font";
            Tab4BrowseFontFileBtnText = "Browse File";
            Tab4CannotReadFontFilePathText = "Cannot get the font file path or the font is not ttf/otf (for SEA server) type. Try use the \"Browse File\"";
            Tab5AboutText = "This tool is made by Kroulis. You can replace you localization file freely with this tool. " +
                "This tool is proudly open sourced with MIT licence. You can check it out in GitHub using the link below. Have fun!";
            FailedToInstallCNFont = "Failed to install the CN Font.";
            FailedToInstallCNFontTitle = "Error";
            BDOLauncherFound = "Found BDO Launcher...";
            BDOLauncherNotFound = "Cannot find BDO Launcher Process. Please start the game Launcher before replacing or restoring the localization file.";
            NewVersionAvailable = "Tool current version {0}, Online version {1}. \r\nDo you want to go to the repo to download the new version?";
            InsiderProgramFormTitle = "Insider Program";
            InsiderProgramTitle = "Join the Insider Program";
            InsiderProgramDescription = "Insider program helps us find bugs and provides us suggestions.\r\nPlease go to the beta branch of the repo to get started.";
            InsiderProgramDetails = "The feature: Scripting is currently available only as insider testing purpose.\r\n" +
                "The beta version is currently available for a limit time to all users.\r\n" +
                "Please check the beta branch in the repo to find out how to join.";
            InsiderProgramLink = "Join the beta program";
        }
    }
}
