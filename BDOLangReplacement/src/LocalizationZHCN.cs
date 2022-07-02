using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDOLangReplacement.Localizations
{
    public class LocalizationZHCN : Localization
    {
        public LocalizationZHCN()
        {
            APPTitle = "黑色沙漠语言包替换工具";
            BDONotFound1 = "无法找到《黑色沙漠》安装目录。您是否想要手动选择《黑色沙漠》安装目录？\n" +
                           "选择“否”：请将本程序放置到《黑色沙漠》根目录下然后重新运行。";
            BDONotFound2 = "此目录为无效的《黑色沙漠》根目录。您想要重新选择吗？\n" +
                           "选择“否”：请将本程序放置到《黑色沙漠》根目录下然后重新运行。";
            BDONotFoundDialogTitle = "找不到《黑色沙漠》安装目录";
            BDOFolderSelectionDescription = "选择《黑色沙漠》根目录";
            Tab1Name = "官方服务器语言包版本";
            Tab2Name = "替换语言包";
            Tab3Name = "安装字体文件";
            Tab4Name = "关于本工具";
            Tab1LabelText = "双击选择目标语言包：";
            Tab1LangUnavailableDialogText = "无法获取此语言包的在线版本。 此语言包暂时不可用。请点击\"刷新\"或者联系作者。";
            Tab1LangUnavailableDialogTitle = "此语言包暂时不可用";
            Tab1RefreshBtnText = "刷新";
            Tab1LangVersionInvalid = "无法获取此语言包的版本";
            Tab1RefreshLog1 = "刷新过程中出现了以下异常：\n";
            Tab1RefreshLog2 = "请联系作者或者在GitHub代码仓库中提交Issue";
            Tab1RefreshLogTitle = "警告";
            Tab1DefaultReplacement1 = "您上次将语言替换成了：\n";
            Tab1DefaultReplacement2 = "\n您想要再次替换成这个语言吗？";
            Tab1DefaultReplacementTitle = "发现了可用的默认替换语言";
            Tab2GameLanguage = "选择您游戏内默认的语言：";
            Tab2ReplacementLanguage = "替换后您的游戏语言为：";
            Tab2IsSteam = "您是通过Steam启动游戏吗？";
            Tab2SteamCheckBox = "通过Steam启动游戏";
            Tab2StartLaunchBtnText = "启动游戏";
            Tab2ReplaceBtnText = "替换";
            Tab2RecoverBtnText = "还原";
            Tab3CNFontBtnText = "安装或卸载 pearl.ttf";
            Tab3FontStatus = "是否已安装：";
            Tab3FontInstalled = "已安装";
            Tab3FontMissing = "未安装";
            Tab3FontTypeSimplifiedChinese = "简体中文";
            Tab3FontTypeTraditionalChinese = "繁体中文";
            Tab4AboutText = "本工具由Kroulis开发。未经授权，严禁转载。代码使用MIT协议开源，您可以通过GitHub代码仓库访问本工具。\r\n" +
                " 额外提醒： 如果您需要将任意其他服务器语言包替换为中文，请确保您在替换语言包后安装字体文件。";
            FailedToInstallCNFont = "中文字体安装失败！";
            FailedToInstallCNFontTitle = "出错了";
            BDOLauncherFound = "发现了执行中的黑色沙漠启动器……";
            BDOLauncherNotFound = "请先启动黑色沙漠启动器然后再替换或还原语言包。";
            NewVersionAvailable = "工具当前版本 {0}, 线上最新版本 {1}。 \r\n请问是否要访问代码仓库以下载最新版本？";
        }
    }
}
