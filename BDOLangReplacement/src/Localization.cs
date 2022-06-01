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
            Tab3CNFontBtnText,
            Tab3FontStatus,
            Tab3FontInstalled,
            Tab3FontMissing,
            Tab4AboutText,
            FailedToInstallCNFont,
            FailedToInstallCNFontTitle,
            BDOLauncherFound,
            BDOLauncherNotFound,
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
        public static string Tab3CNFontBtnText;
        public static string Tab3FontStatus;
        public static string Tab3FontInstalled;
        public static string Tab3FontMissing;
        public static string Tab4AboutText;
        public static string FailedToInstallCNFont;
        public static string FailedToInstallCNFontTitle;
        public static string BDOLauncherFound;
        public static string BDOLauncherNotFound;


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
                case FormComponent.Tab3CNFontBtnText:
                    return Tab3CNFontBtnText;
                case FormComponent.Tab3FontStatus:
                    return Tab3FontStatus;
                case FormComponent.Tab3FontInstalled:
                    return Tab3FontInstalled;
                case FormComponent.Tab3FontMissing:
                    return Tab3FontMissing;
                case FormComponent.Tab4AboutText:
                    return Tab4AboutText;
                case FormComponent.FailedToInstallCNFont:
                    return FailedToInstallCNFont;
                case FormComponent.FailedToInstallCNFontTitle:
                    return FailedToInstallCNFontTitle;
                case FormComponent.BDOLauncherFound:
                    return BDOLauncherFound;
                case FormComponent.BDOLauncherNotFound:
                    return BDOLauncherNotFound;
            }
            return "";
        }
    }

    
}
