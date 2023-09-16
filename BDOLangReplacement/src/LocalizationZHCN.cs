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
            Tab3Name = "高级工具";
            Tab4Name = "安装字体文件";
            Tab5Name = "关于本工具";
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
            Tab2AdvancedText = "高级操作";
            Tab2MergeBtnText = "合并";
            Tab2ScriptBtnText = "脚本";
            Tab3HelperToolStatusText = "语言包工具箱版本信息";
            Tab3HelperToolLocalVersionText = "本地版本：";
            Tab3HelperToolOnlineVersionText = "在线版本：";
            Tab3HelperToolVersionUnavailable = "无法获取";
            Tab3InstallUpdateHelperToolBtnText = "安装/更新";
            Tab3UninstallHelperToolBtnText = "卸载";
            Tab3AdvancedOperationGroupText = "使用工具箱进行操作";
            Tab3AdvancedOpCodeLabelText = "选择操作:";
            Tab3AdvancedOpSrcFileLabelText = "源文件:";
            Tab3AdvancedOpOutFileLabelText = "输出到:";
            Tab3AdvancedOpAddtionalFile1Text = "额外文件1:";
            Tab3AdvancedOpAddtionalFile2Text = "额外文件2:";
            Tab3AdvancedOpExecuteBtnText = "执行";
            Tab3AdvancedOpBrowseBtnText = "浏览";
            Tab3AdvancedOpCodeSelectBoxItems = "加密 [文本文件->本地化文件(语言包)]\n解密 [本地化文件(语言包)->文本文件]\n生成差别词条 [限文本文件]\n合并 [将多个文本文件合并为一个文本文件]\n繁体中文转简体中文 [限文本文件]";
            Tab3InstallHelperToolFirstText = "无法找到辅助工具箱。请先安装辅助工具箱。";
            Tab4CNFontBtnText = "安装或卸载 pearl.ttf";
            Tab4FontStatus = "是否已安装：";
            Tab4FontInstalled = "已安装";
            Tab4FontMissing = "未安装";
            Tab4FontTypeSimplifiedChinese = "简体中文";
            Tab4FontTypeTraditionalChinese = "繁体中文";
            Tab4EmbeddedFontText = "内置字体";
            Tab4CustomFontText = "安装自选字体";
            Tab4CustomFontBoxText = "自选字体安装到游戏内:";
            Tab4BrowseFontBtnText = "选择字体";
            Tab4BrowseFontFileBtnText = "从文件选择字体";
            Tab4CannotReadFontFilePathText = "无法取得字体文件或字体文件不是ttf (如果您是SEA服务器的话 otf)类型。请使用\"从文件选择字体\"";
            Tab5AboutText = "本工具由Kroulis开发。未经授权，严禁转载。代码使用MIT协议开源，您可以通过GitHub代码仓库访问本工具。\r\n" +
                " 额外提醒： 如果您需要将任意其他服务器语言包替换为中文，请确保您在替换语言包后安装字体文件。";
            FailedToInstallCNFont = "中文字体安装失败！";
            FailedToInstallCNFontTitle = "出错了";
            BDOLauncherFound = "发现了执行中的黑色沙漠启动器……";
            BDOLauncherNotFound = "请先启动黑色沙漠启动器然后再替换或还原语言包。";
            NewVersionAvailable = "工具当前版本 {0}, 线上最新版本 {1}。 \r\n请问是否要访问代码仓库以下载最新版本？";
            InsiderProgramFormTitle = "测试功能";
            InsiderProgramTitle = "加入测试计划";
            InsiderProgramDescription = "测试计划帮助我们修复程序漏洞以及能为我们提供宝贵的意见。\r\n请通过代码仓库的beta分支了解如何加入本计划。";
            InsiderProgramDetails = "脚本功能当前只为测试计划内的用户提供。\r\n" +
                "测试计划目前限时为所有用户开放。\r\n" +
                "请通过代码仓库内的beta分支了解如何进入此计划。\r\n" +
                "注意：由于此计划的首要任务是保证程序功能的正常执行，测试计划内的功能可能没有汉化的界面。请谅解！";
            InsiderProgramLink = "点击这里了解更多";
        }
    }
}
