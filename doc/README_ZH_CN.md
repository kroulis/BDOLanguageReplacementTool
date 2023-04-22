# 《黑色沙漠》语言包替换工具 （Beta1）

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
请查看Master分支的文档以获取使用方式。

## 如何加入Beta1测试计划
在 `2023年6月1日 00:00:00 AM UTC时区`前，你可以使用以下的邀请码加入测试计划：
```
KjsxNjg1NjAyODAwIzNGQjkwQTcyOENDMUFFMDgwRjYyQTEyNDhCRURBRUZCQzU0MkI1NTgxMjRGNzE3MDkyMjhBQjM3MkE5QkY1OEZCRjlGQUREN0FBMkIwOThBMzVFMjVGOTIyMURENzZBNzBDM0M0NUVCNTNFRURBNDUwOTAxOTFGRTZGRTVGQjExMzIwQzk4NkYxNEM1RDNGNkVDN0IwMzdDMUM5RUVBQjc3NDAxMUMwQkZDQzQyRjE2MjJERTlGQ0Y5NERGQkM1Q0M2RTkyRjhFODFCMDA2MDY2QzIwMzc5OUE2MzgzRjdGREU0ODYwNERERDQyOTZEMEZCMzIzOTI2NzFDRUQ4Rjg=
```
在上述日期后，请联系本代码仓库作者以获取邀请码。

## 如何激活测试功能
请先下载Beta1版本的预编译可执行文件。

使用与正式版相同的方式设置游戏内语言与目标语言。

点击`脚本`按钮，在邀请码框中输入你获得的测试邀请码，然后点击`激活`按钮。

如果您的邀请码有效，您将自动获得测试脚本功能的权限。

## 测试目标：
1. 测试`新功能：脚本`是否正常允许：
	+ 创建/修改/执行 一个本地的脚本
	+ 执行一个在线脚本。范例被放置于：
		- https://raw.githubusercontent.com/kroulis/BDOLanguageReplacementTool/beta/official/scripts/merge.yml
		- https://raw.githubusercontent.com/kroulis/BDOLanguageReplacementTool/beta/official/scripts/twcn2zhcn.yml
		- https://raw.githubusercontent.com/kroulis/BDOLanguageReplacementTool/beta/official/scripts/twcnwithfix.yml
2. 向我们提供任何建议。

## Beta 1 加入的新功能
添加了脚本功能。脚本可以让您执行一系列复杂的操作来修改语言包文件。您可以通过工具自带的图形编辑器或通过文本编辑器创建或修改脚本。

本次测试提供给您以下的范例脚本：
+ 一个可以将两个语言包合并的脚本。
+ 一个可以将游戏内语言对应的语言包修改为繁体中文（台服）语言包并自动修复大部分缺失词条的脚本。
+ 一个可以将游戏内语言对应的语言包修改为简体中文（台服）语言包并自动修复大部分缺失词条的脚本。
