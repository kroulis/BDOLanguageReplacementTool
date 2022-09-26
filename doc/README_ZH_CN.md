# 《黑色沙漠》语言包替换文件 [![编译](https://github.com/kroulis/BDOLanguageReplacementTool/actions/workflows/dotnet.yml/badge.svg)](https://github.com/kroulis/BDOLanguageReplacementTool/actions/workflows/dotnet.yml) [![测试](https://github.com/kroulis/BDOLanguageReplacementTool/actions/workflows/unit_test.yml/badge.svg)](https://github.com/kroulis/BDOLanguageReplacementTool/actions/workflows/unit_test.yml)

本程序可帮助您将已安装的黑色沙漠的默认语言文件包替换成任意其他服务器的语言包文件。 本工具目前支持：
- NAEU Server （欧美服）
- SEA Server （东南亚服）
- TW Server （台服）
- JP Server （日服）
- RU Server （俄服）
- TR Server （土耳其服）
- SA Server （南美服）
- Global Lab Server （全球实验室服）

本工具目前不支持：
- Korea Server （韩服）

## 如何使用本工具：
1. 您可以克隆本代码仓库然后使用Visual Studio编译或者下载预编译的可执行文件。
    - 为了保证您计算机的安全，请确保下载的预编译可执行文件的MD5码与本代码仓库所提供的一致
2. 您可以将本工具（的可执行文件）放置到黑色沙漠的安装根目录下，或者在工具提示后手动选择黑色沙漠根目录。
3. 等待工具读取最新的语言包版本文件。
4. （推荐）您可以在“关于”页面中选择中文为工具语言。本工具提供中文界面。
5. 双击想要替换为的语言包。
6. 选择当前客户端的默认语言。 您可以在游戏或启动器中查看当前的默认语言。
7. 通过工具或者自行启动黑色沙漠启动器 （注意：如果您通过Steam来启动游戏，请确保对应的单选框为选中状态）
8. 登入黑色沙漠启动器并等待游戏更新完成。
9. 点击“替换按钮”。
10. （注意：如果您在汉化游戏，请确保中文字体已安装。 本工具提供有效的汉化字体，请通过“安装字体”栏安装中文字体。 这是一次性的操作。）
11. 点击游戏启动器中的开始游戏。
12. 恭喜您，您的语言包被成功替换了。

## 本工具自动保存您的选择

本工具自动保存您上一次的选择。当您完成步骤4至步骤9一次后，下一次重新启动本工具，工具会自动帮您完成默认语言和替换语言的选择。

## 于1.1版本增加的功能
1. 增加了一键合并语言包的功能。 当语言包内缺少部分翻译时，在游戏内会显示为韩文或者显示为空。 本功能能将只存在于原先语言包内的词条复制到替换的语言包中以解决问题。这个功能在`替换语言包`分页中显示为`合并`。
2. 增加了加密、解密、生成差别词条、合并语言包的功能。这些功能被放置在`高级工具`分页中。（如果需要使用此功能，您需要额外下载辅助工具包。程序内提供一键化的下载安装。 如果您对此工具感到好奇，您可以访问 [kroulis/BDOLangReplacementToolHelper](https://github.com/kroulis/BDOLangReplacementToolHelper)）

## 致谢

特别感谢 **[Reddit 帖](https://www.reddit.com/r/blackdesertonline/comments/p8vjss/guide_all_your_bdo_language_file_needs/)** 为本工具提供思路。

## 疑难问题
如果您发现代码有任何Bug，请通过Issues提交。我会经常查看本代码仓库。
