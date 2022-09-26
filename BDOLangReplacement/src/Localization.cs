using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDOLangReplacement.Localizations
{
    public abstract class Localization
    {
        public enum FormComponent
        {
            APPTitle = 0,
            BDONotFound1,
            BDONotFound2,
            BDONotFoundDialogTitle,
            BDOFolderSelectionDescription,
            Tab1Name,
            Tab2Name,
            Tab3Name,
            Tab4Name,
            Tab5Name,
            Tab1LabelText,
            Tab1LangUnavailableDialogText,
            Tab1LangUnavailableDialogTitle,
            Tab1RefreshBtnText,
            Tab1LangVersionInvalid,
            Tab1RefreshLog1,
            Tab1RefreshLog2,
            Tab1RefreshLogTitle,
            Tab1DefaultReplacement1,
            Tab1DefaultReplacement2,
            Tab1DefaultReplacementTitle,
            Tab2GameLanguage,
            Tab2ReplacementLanguage,
            Tab2IsSteam,
            Tab2SteamCheckBox,
            Tab2StartLaunchBtnText,
            Tab2ReplaceBtnText,
            Tab2RecoverBtnText,
            Tab2AdvancedText,
            Tab2MergeBtnText,
            Tab2ScriptBtnText,
            Tab3HelperToolStatusText,
            Tab3HelperToolLocalVersionText,
            Tab3HelperToolOnlineVersionText,
            Tab3HelperToolVersionUnavailable,
            Tab3InstallUpdateHelperToolBtnText,
            Tab3UninstallHelperToolBtnText,
            Tab3AdvancedOperationGroupText,
            Tab3AdvancedOpCodeLabelText,
            Tab3AdvancedOpSrcFileLabelText,
            Tab3AdvancedOpOutFileLabelText,
            Tab3AdvancedOpAddtionalFile1Text,
            Tab3AdvancedOpAddtionalFile2Text,
            Tab3AdvancedOpExecuteBtnText,
            Tab3AdvancedOpBrowseBtnText,
            Tab3AdvancedOpCodeSelectBoxItems,
            Tab3InstallHelperToolFirstText,
            Tab4CNFontBtnText,
            Tab4FontStatus,
            Tab4FontInstalled,
            Tab4FontMissing,
            Tab4FontTypeSimplifiedChinese,
            Tab4FontTypeTraditionalChinese,
            Tab4EmbeddedFontText,
            Tab4CustomFontText,
            Tab4CustomFontBoxText,
            Tab4BrowseFontBtnText,
            Tab4BrowseFontFileBtnText,
            Tab4CannotReadFontFilePathText,
            Tab5AboutText,
            FailedToInstallCNFont,
            FailedToInstallCNFontTitle,
            BDOLauncherFound,
            BDOLauncherNotFound,
            NewVersionAvailable,
            MAX
        }

        public static string APPTitle;
        public static string BDONotFound1;
        public static string BDONotFound2;
        public static string BDONotFoundDialogTitle;
        public static string BDOFolderSelectionDescription;
        public static string Tab1Name;
        public static string Tab2Name;
        public static string Tab3Name;
        public static string Tab4Name;
        public static string Tab5Name;
        public static string Tab1LabelText;
        public static string Tab1LangUnavailableDialogText;
        public static string Tab1LangUnavailableDialogTitle;
        public static string Tab1RefreshBtnText;
        public static string Tab1LangVersionInvalid;
        public static string Tab1RefreshLog1;
        public static string Tab1RefreshLog2;
        public static string Tab1RefreshLogTitle;
        public static string Tab1DefaultReplacement1;
        public static string Tab1DefaultReplacement2;
        public static string Tab1DefaultReplacementTitle;
        public static string Tab2GameLanguage;
        public static string Tab2ReplacementLanguage;
        public static string Tab2IsSteam;
        public static string Tab2SteamCheckBox;
        public static string Tab2StartLaunchBtnText;
        public static string Tab2ReplaceBtnText;
        public static string Tab2RecoverBtnText;
        public static string Tab2AdvancedText;
        public static string Tab2MergeBtnText;
        public static string Tab2ScriptBtnText;
        public static string Tab3HelperToolStatusText;
        public static string Tab3HelperToolLocalVersionText;
        public static string Tab3HelperToolOnlineVersionText;
        public static string Tab3HelperToolVersionUnavailable;
        public static string Tab3InstallUpdateHelperToolBtnText;
        public static string Tab3UninstallHelperToolBtnText;
        public static string Tab3AdvancedOperationGroupText;
        public static string Tab3AdvancedOpCodeLabelText;
        public static string Tab3AdvancedOpSrcFileLabelText;
        public static string Tab3AdvancedOpOutFileLabelText;
        public static string Tab3AdvancedOpAddtionalFile1Text;
        public static string Tab3AdvancedOpAddtionalFile2Text;
        public static string Tab3AdvancedOpExecuteBtnText;
        public static string Tab3AdvancedOpBrowseBtnText;
        public static string Tab3AdvancedOpCodeSelectBoxItems;
        public static string Tab3InstallHelperToolFirstText;
        public static string Tab4CNFontBtnText;
        public static string Tab4FontStatus;
        public static string Tab4FontInstalled;
        public static string Tab4FontMissing;
        public static string Tab4FontTypeSimplifiedChinese;
        public static string Tab4FontTypeTraditionalChinese;
        public static string Tab4EmbeddedFontText;
        public static string Tab4CustomFontText;
        public static string Tab4CustomFontBoxText;
        public static string Tab4BrowseFontBtnText;
        public static string Tab4BrowseFontFileBtnText;
        public static string Tab4CannotReadFontFilePathText;
        public static string Tab5AboutText;
        public static string FailedToInstallCNFont;
        public static string FailedToInstallCNFontTitle;
        public static string BDOLauncherFound;
        public static string BDOLauncherNotFound;
        public static string NewVersionAvailable;


        public string localize(FormComponent fc)
        {
            switch (fc)
            {
                case FormComponent.APPTitle:
                    return APPTitle;
                case FormComponent.BDONotFound1:
                    return BDONotFound1;
                case FormComponent.BDONotFound2:
                    return BDONotFound2;
                case FormComponent.BDONotFoundDialogTitle:
                    return BDONotFoundDialogTitle;
                case FormComponent.BDOFolderSelectionDescription:
                    return BDOFolderSelectionDescription;
                case FormComponent.Tab1Name:
                    return Tab1Name;
                case FormComponent.Tab2Name:
                    return Tab2Name;
                case FormComponent.Tab3Name:
                    return Tab3Name;
                case FormComponent.Tab4Name:
                    return Tab4Name;
                case FormComponent.Tab5Name:
                    return Tab5Name;
                case FormComponent.Tab1LabelText:
                    return Tab1LabelText;
                case FormComponent.Tab1LangUnavailableDialogText:
                    return Tab1LangUnavailableDialogText;
                case FormComponent.Tab1LangUnavailableDialogTitle:
                    return Tab1LangUnavailableDialogTitle;
                case FormComponent.Tab1RefreshBtnText:
                    return Tab1RefreshBtnText;
                case FormComponent.Tab1LangVersionInvalid:
                    return Tab1LangVersionInvalid;
                case FormComponent.Tab1RefreshLog1:
                    return Tab1RefreshLog1;
                case FormComponent.Tab1RefreshLog2:
                    return Tab1RefreshLog2;
                case FormComponent.Tab1RefreshLogTitle:
                    return Tab1RefreshLogTitle;
                case FormComponent.Tab1DefaultReplacement1:
                    return Tab1DefaultReplacement1;
                case FormComponent.Tab1DefaultReplacement2:
                    return Tab1DefaultReplacement2;
                case FormComponent.Tab1DefaultReplacementTitle:
                    return Tab1DefaultReplacementTitle;
                case FormComponent.Tab2GameLanguage:
                    return Tab2GameLanguage;
                case FormComponent.Tab2ReplacementLanguage:
                    return Tab2ReplacementLanguage;
                case FormComponent.Tab2IsSteam:
                    return Tab2IsSteam;
                case FormComponent.Tab2SteamCheckBox:
                    return Tab2SteamCheckBox;
                case FormComponent.Tab2StartLaunchBtnText:
                    return Tab2StartLaunchBtnText;
                case FormComponent.Tab2ReplaceBtnText:
                    return Tab2ReplaceBtnText;
                case FormComponent.Tab2RecoverBtnText:
                    return Tab2RecoverBtnText;
                case FormComponent.Tab2AdvancedText:
                    return Tab2AdvancedText;
                case FormComponent.Tab2MergeBtnText:
                    return Tab2MergeBtnText;
                case FormComponent.Tab2ScriptBtnText:
                    return Tab2ScriptBtnText;
                case FormComponent.Tab3HelperToolStatusText:
                    return Tab3HelperToolStatusText;
                case FormComponent.Tab3HelperToolLocalVersionText:
                    return Tab3HelperToolLocalVersionText;
                case FormComponent.Tab3HelperToolOnlineVersionText:
                    return Tab3HelperToolOnlineVersionText;
                case FormComponent.Tab3HelperToolVersionUnavailable:
                    return Tab3HelperToolVersionUnavailable;
                case FormComponent.Tab3InstallUpdateHelperToolBtnText:
                    return Tab3InstallUpdateHelperToolBtnText;
                case FormComponent.Tab3UninstallHelperToolBtnText:
                    return Tab3UninstallHelperToolBtnText;
                case FormComponent.Tab3AdvancedOperationGroupText:
                    return Tab3AdvancedOperationGroupText;
                case FormComponent.Tab3AdvancedOpCodeLabelText:
                    return Tab3AdvancedOpCodeLabelText;
                case FormComponent.Tab3AdvancedOpSrcFileLabelText:
                    return Tab3AdvancedOpSrcFileLabelText;
                case FormComponent.Tab3AdvancedOpOutFileLabelText:
                    return Tab3AdvancedOpOutFileLabelText;
                case FormComponent.Tab3AdvancedOpAddtionalFile1Text:
                    return Tab3AdvancedOpAddtionalFile1Text;
                case FormComponent.Tab3AdvancedOpAddtionalFile2Text:
                    return Tab3AdvancedOpAddtionalFile2Text;
                case FormComponent.Tab3AdvancedOpExecuteBtnText:
                    return Tab3AdvancedOpExecuteBtnText;
                case FormComponent.Tab3AdvancedOpBrowseBtnText:
                    return Tab3AdvancedOpBrowseBtnText;
                case FormComponent.Tab3AdvancedOpCodeSelectBoxItems:
                    return Tab3AdvancedOpCodeSelectBoxItems;
                case FormComponent.Tab3InstallHelperToolFirstText:
                    return Tab3InstallHelperToolFirstText;
                case FormComponent.Tab4CNFontBtnText:
                    return Tab4CNFontBtnText;
                case FormComponent.Tab4FontStatus:
                    return Tab4FontStatus;
                case FormComponent.Tab4FontInstalled:
                    return Tab4FontInstalled;
                case FormComponent.Tab4FontMissing:
                    return Tab4FontMissing;
                case FormComponent.Tab4FontTypeSimplifiedChinese:
                    return Tab4FontTypeSimplifiedChinese;
                case FormComponent.Tab4FontTypeTraditionalChinese:
                    return Tab4FontTypeTraditionalChinese;
                case FormComponent.Tab4EmbeddedFontText:
                    return Tab4EmbeddedFontText;
                case FormComponent.Tab4CustomFontText:
                    return Tab4CustomFontText;
                case FormComponent.Tab4CustomFontBoxText:
                    return Tab4CustomFontBoxText;
                case FormComponent.Tab4BrowseFontBtnText:
                    return Tab4BrowseFontBtnText;
                case FormComponent.Tab4BrowseFontFileBtnText:
                    return Tab4BrowseFontFileBtnText;
                case FormComponent.Tab4CannotReadFontFilePathText:
                    return Tab4CannotReadFontFilePathText;
                case FormComponent.Tab5AboutText:
                    return Tab5AboutText;
                case FormComponent.FailedToInstallCNFont:
                    return FailedToInstallCNFont;
                case FormComponent.FailedToInstallCNFontTitle:
                    return FailedToInstallCNFontTitle;
                case FormComponent.BDOLauncherFound:
                    return BDOLauncherFound;
                case FormComponent.BDOLauncherNotFound:
                    return BDOLauncherNotFound;
                case FormComponent.NewVersionAvailable:
                    return NewVersionAvailable;
            }
            return "";
        }
    }

    
}
