# 《黑色沙漠》语言包替换工具 （Beta2）

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

## 如何加入Beta2测试计划
在 `2023年12月1日 00:00:00 AM UTC时区`前，你可以使用以下的邀请码加入测试计划：
```
KjsxNzAxNDE3NjAwIzY5MkUyMUM5RDQ1Qzc1NzM1ODE4MkM1MUMwNkE0NENBNzc5NTkxNEQxOUI4OTIwRDA4Njc2NzE5QjhDMjMxRjIyQTBEMjI1NDNBRjQ2NUU1REFENkJGOTkxNzU5M0ExREQ3NDMyM0Y1MjQ5NUJDOEI0Nzk4MDI2RDBDQzk0QTg1NkU0QzM4MDBGMDBBMUM5MjJDNUZGQTgwNEZDRDFDNzcxQzZGRjU3OTc2NEQ5RTc5OTlCQUUwODM1MDNDOTkxMUY5OTBEQUFBOEM2ODBEQzZFODVCQTA0MjVGMjk0ODdBQzJENEE4REM0NEY2QkI2NENFRTQzRkExMTUzQjkxODI=
```
在上述日期后，请联系本代码仓库作者以获取邀请码。

## 如何激活测试功能
请先下载Beta1版本的预编译可执行文件。

使用与正式版相同的方式设置游戏内语言与目标语言。

在高级工具页面中，点击`脚本编辑工具`按钮，在邀请码框中输入你获得的测试邀请码，然后点击`激活`按钮。

如果您的邀请码有效，您将自动获得测试脚本功能的权限。

## 测试目标：
1. 测试`新功能：脚本`是否正常允许：
	+ 创建/修改/执行 一个本地的脚本
	+ 执行一个在线脚本。范例被放置于：
		- https://raw.githubusercontent.com/kroulis/BDOLanguageReplacementTool/beta/official/scripts/merge.yml
		- https://raw.githubusercontent.com/kroulis/BDOLanguageReplacementTool/beta/official/scripts/twcn2zhcn.yml
		- https://raw.githubusercontent.com/kroulis/BDOLanguageReplacementTool/beta/official/scripts/twcnwithfix.yml
2. 向我们提供任何建议。

## Beta 2 修改内容表
将脚本编辑工具移动到了`高级工具`页面中来降低软件的繁杂度。  
因此`替换语言包`页面下的脚本按钮会提供一个简单的页面来让您直接执行脚本。
修复了beta 1版本中的部分bug:
 + 修复了脚本工具窗口中`刷新`按钮的文字
 + 修复了读取含有非英语文本的远程脚本（通过URL获取的脚本）会出现乱码的情况。
 
 优化了软件本地化。
 为字体安装增加了一个警告信息。当无法读取黑色沙漠的配置文件时（这很有可能说明玩家在安装黑色沙漠后从来没有启动过游戏），软件会警告用户其所安装的字体可能无法被读取。

## Beta 1 加入的新功能
添加了脚本功能。脚本可以让您执行一系列复杂的操作来修改语言包文件。您可以通过工具自带的图形编辑器或通过文本编辑器创建或修改脚本。

本次测试提供给您以下的范例脚本：
+ 一个可以将两个语言包合并的脚本。
+ 一个可以将游戏内语言对应的语言包修改为繁体中文（台服）语言包并自动修复大部分缺失词条的脚本。
+ 一个可以将游戏内语言对应的语言包修改为简体中文（台服）语言包并自动修复大部分缺失词条的脚本。
