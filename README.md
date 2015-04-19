KanColleViewer! (提督業も忙しい！汉语：提督很忙!)
--

KCV是一个添加了若干辅助功能的舰娘用浏览器。
万恶之源：[KanColleViewer](http://grabacr.net/kancolleviewer)

本项目基于Clicia 的KCV版本进行本地化。[Clicia 's KanColleViewer](https://github.com/yuyuvn/KanColleViewer)

##### 主要贡献者
* [杏奈、Mr.WinWin](https://github.com/AnnaKutou) -- 维护者
* [Clicia](https://github.com/yuyuvn) -- 源项目
* [@Zharay](http://twitter.com/Zharay) -- 英语版本
* [@Grabacr07](https://twitter.com/Grabacr07) -- 原作者
* [silfumus](https://github.com/silfumus) -- 工作者 (已失去维护)
* [southrop](https://github.com/southrop) -- 源翻译系统代码 (已失去维护)
* [m-kc](https://github.com/m-kc) -- 排名部分
* [taihou](https://github.com/taihou) -- 日志功能
* [FreyYa](https://github.com/FreyYa) -- 自定义声音
* [Paddy Xu](https://github.com/Xupefei) -- 记录检视

##### 下载
可在下面的链接里下载
* [度盘](http://pan.baidu.com/s/1qWC1RL6)

## 这货和Grabarc07的原版KCV有什么区别吗?
* 可横屏竖屏切换
* 物品，船名有翻译，任务标注完成条件，远征标注奖励。
* 舰队详情面板
* 可查看装备信息
* 可查看排名信息（插件）
* 肝船计算器（插件）
* 掉落、建造记录检视（插件）
* 自动检查更新
* 可以通过设置Cookies直连
* 可改变Flash画质来提升渣配置电脑（比如国产寨板）的流畅度
* 可自定义声音提醒
* 可记录掉落建造
* 集成了d.f.32的缓存插件（不提供源码，如果作者对我的行为感到反感，请告诉我，我会撤下插件。）

（这是Clicia的原文）Other than the above, this version is the same with some tweaks to make it fit for an English translation. The plan is to hopefully add some features into the main project for all to enjoy.

## FAQ:

#### KCV安全吗?
当然没问题，KCV就是以IE浏览器为基础，仅仅是把你游戏时候的flash单独窗口提取出来。KCV也会显示舰船，装备，舰队等等信息。当然KCV不会篡改任何用户数据。
**它绝不会修改游戏本身或者修改数据包**
对于其他自称“安全”解决方案来说，他们和这东西一样要求你使用API链接，要背锅的话也是一起背锅。

#### 我如何不通过VPN使用KCV?
在登陆前或登录后，按下“设置地区Cookie”按钮。这会让你的身份识别状态从非日本IP用户变为日本IP用户。这并不会真的改变你的IP或者使用类似手段，只是更改了你Cookie里的区域标示。

#### 这直连Cookie安全吗?
不敢打保票，但是它确实给了那些不在日本的海外（非洲or欧洲）提督相当大的便利。但是，舰娘官推是知道有非日本本地的外国提督在玩舰娘的，DMM也明确表示了不会给这些海外提督任何支持和帮助。所以最好的方法还是使用日本本地的代理（VPN），这样可以更安全更高效艹舰。

#### 我的游戏画面跟有波浪起伏一样，但在 Chrome/Firefox/Flash上正常。
把你的IE升级到你系统所支持的最新版本。Win7可以来这里安装[Internet Explorer 11](http://windows.microsoft.com/en-us/internet-explorer/ie-11-worldwide-languages) 。这是他们今年搞出来的最新版了。

另外也确认你的 [Flash for Internet Explorer](http://get.adobe.com/flashplayer/otherversions/) 是最新版本或者安装了没！

#### 游戏没开始或者KCV要我下载一个Flash而不是直接进游戏。
装[Flash for Internet Explorer](http://get.adobe.com/flashplayer/otherversions/) 或者检查你的杀软是不是又坑爹了。

#### 我是Win7系统，这东西不干活！
你需要[.NET Framework 4.5](http://www.microsoft.com/en-us/download/details.aspx?id=30653) 。当然，Win8不用，因为它自带了。

#### 我是Windows XP/Mac/Linux系统但我也想拿这个艹船！
请允许我做一个北上的表情。巨硬不让XP/Mac/Linux 支持.NET 4.5。于是你有两个选择：升级系统或者用[Logbook](https://github.com/Zharay/logbook) ——另一个基于JAVA的舰娘辅助，有关问题找这家伙 [@Zharay](http://twitter.com/Zharay)。这东西要简单很多，但也是个相当了不起的工程。当然，XP用户可以找找早期版本基于.NET 4.0的KCV（我这里没有）。

####我白屏了/我报错无法连接。
请务必在发生这种苦逼的事情的时候告知我们你系统的IE版本号，好让我们幸灾乐祸一下（雾）。其实，一般情况，都是IE版本过于老旧的锅。你可以试试更新IE浏览器。其实还有一些情报显示清除缓存和cookies或是重装flash也可以解决问题。

如果你遇到的是连接问题（connection errors），试试用文本编辑器打开KanColleViewer.exe.config这个文件换个代理服务器，ctrl+F查找数字37564并替换成37565或是随便一个数字都行。然后重启KCV，看看问题是不是解决了。

#### 我的舰队和远征信息不会刷新!
清缓存后重启KCV。尤其是你升级KCV或者用俩不同发行版本的KCV时。这么做后应该就没问题了。

#### 我想让船名装备名之类的显示成日文。
最简单的方法就是禁用选项里的翻译功能。你也能去把语言换成日文（这会让所有翻译都失效）。如果你只想让特定内容显示翻译，那么把translations文件夹里无关的xml文件删掉就好了（记得禁用自动更新）。

#### 我看不懂XXX（XXX还没翻译！）
你遇到这问题后请务必帮我一下。翻译引擎可以把新出现的内容加到XML文件后面。找到未翻译内容，然后来这里反馈给我。

#### 就算我换了语言可船名物品名还是英文！
你丫下载的一定不是我的东西      ——杏奈。

Clicia的版本已经不再支持多语言了，如果你想用其他分支版本KCV的翻译，去改KanColleViewer.exe.config里面KCVUpdateUrl的值为你想用分支的，然后去KCV里强制更新翻译文件，当然，因为是其他分支的，我不能保证他们会不会半路弃坑不做。

####自定义通知音是什么鬼？
这些通知音会在windows的通知弹出的同时播放。支持的格式有WAV和MP3，你可以在KCV的根目录找到一个SOUNDS的目录，点进去，你把你准备好的音频文件扔进对应目录就好了，简单吧。不用理会名字或是序号什么的。放进去，然后在KCV会随机播放一个（多文件情况下）。

注意！你界面选的什么语言，你就放进什么语言的文件夹里，如果没有那个文件夹，你自己先搞出一个通知，自然就会创建文件夹了。
（杏奈：举个栗子吧，如果你是中文使用者而界面语言选择的是英文，那么你想改更新提示音的话，就得放进Updater里而不是更新里）

## 关于项目
KCV使用 the Windows Presentation Foundation (WPF) 的内置浏览器组件 [FiddlerCore](http://fiddler2.com/fiddlercore) 来捕获服务器与网页的通讯内容。

当然，我们不会去改变数据包内容，只是拿来提供数据显示。

### 关于翻译
船、装备、任务的翻译文件源自现在已失去维护的[silfumus' version of KanColleViewer](https://github.com/silfumus/KanColleViewer) 现在Zharay会继续做一些维护工作。

翻译工作原理是从几个含有原文和译文的xml文件里提取内容来进行显示。理论上可以用来翻译成任何语言。

### 主要特点（原版KCV）
* 实时显示桶和资材等数据。
* 实时显示持有舰娘数和持有装备数。
* 列出你拥有的所有舰娘。
* 入渠和建造计时器及通知。
* 列出已接受任务和每日每周每月任务。
* 截屏保存
* 静音

### 环境要求
* Windows 8 或更高
* Windows 7 (需要手动安装支持库)
* [.NET Framework 4.5](http://www.microsoft.com/ja-jp/download/details.aspx?id=30653)

开发测试于Windows 8.1 Pro平台. Windows 7 可以用这个, 但是通知出现方式会和Win8有点不同（win7是气泡）。

Win7需要安装.NET Framework 4.5. Windows 8 已内置。

### 开发环境、语言、库。
主要使用 C# + WPF 在 Windows 8.1 Pro 使用 Visual Studio Premium 2013开发。

* [Reactive Extensions](http://rx.codeplex.com/)
* Interactive Extensions
* [Windows API Code Pack](http://archive.msdn.microsoft.com/WindowsAPICodePack)
* [Livet](http://ugaya40.net/livet) (MVVM Infrastructure)
* [DynamicJson](http://dynamicjson.codeplex.com/) (JSON deserialization processing)
* [FiddlerCore](http://fiddler2.com/fiddlercore) (Network capture)


#### 许可协议
* MIT License

遵循MIT license作为开源、免费软件发行。
