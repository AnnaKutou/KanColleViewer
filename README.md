KanColleViewer! (提督業も忙しい！汉语：提督很忙!)
--

KCV是一个添加了若干辅助功能的舰娘用浏览器。
源项目：[KanColleViewer](http://grabacr.net/kancolleviewer)

本项目基于yuyuvn的KCV版本进行本地化。[yuyuvn's KanColleViewer](https://github.com/yuyuvn/KanColleViewer)

##### 主要贡献者
* [Clicia](https://github.com/yuyuvn) -- Maintainer
* [@Zharay](http://twitter.com/Zharay) -- English Version
* [@Grabacr07](https://twitter.com/Grabacr07) -- Original author
* [silfumus](https://github.com/silfumus) -- Continued Work (defunct)
* [southrop](https://github.com/southrop) -- Original text file translation code (defunct)
* [m-kc](https://github.com/m-kc) -- Rankings section
* [taihou](https://github.com/taihou) -- Logging option
* [FreyYa](https://github.com/FreyYa) -- Custom Sound
* [杏奈](https://github.com/AnnaKutou)、Mr.WinWin -- 中文本土化

## 下载
可在下面的链接里下载

* [度盘](http://pan.baidu.com/s/1qWC1RL6)

## FAQ:

#### KCV安全吗?
Yes. You are mainly playing off Internet Explorer (IE). The program itself wraps itself around IE and captures all network coming in and out. It only looks for incoming data and uses that for displaying in game information such as ships, expeditions, quests, and so on. **This does not change the game itself in any way**. **It does not change the packets in any way**. For other solutions to say that their version is "safer" while they are asking you to use an API link are just as much a problem as it is with this program.

#### 我如何不通过VPN使用KCV?
Before or after logging in, press the "Set Regional Cookie" button. This will change your status from being an IP from outside Japan to being a Japanese native one. It doesn't change your IP or do anything else except change a flag value on your visitor cookie.

#### 这Cookie安全吗?
By all means it is. But it does mean that it makes playing Kancolle a ton easier for regions that DMM does not support. From their twitter responses, they are alright with foreigners playing the game, but they will not provide any support for those outside of Japan. Until they change this rather open method of delegating foreigners from non-foreigners, this is probably the easiest way to play (and possibly register for) the game itself.

#### 我的游戏画面跟有波浪起伏一样，但在 Chrome/Firefox/Flash上正常。
Update Internet Explorer to the latest version available for your build of Windows. Windows 7 can go all the way to [Internet Explorer 11](http://windows.microsoft.com/en-us/internet-explorer/ie-11-worldwide-languages) which is by far the fastest version of IE they've made in years.

Also be sure to have the latest version of [Flash for Internet Explorer](http://get.adobe.com/flashplayer/otherversions/) installed!

#### 游戏没开始或者KCV要我下载一个Flash而不是直接进链接。
Install [Flash for Internet Explorer](http://get.adobe.com/flashplayer/otherversions/). You may also have to disable any programs that have been installed on to IE without your consent such as antivirus software and other programs.

#### 我是Win7系统，这东西不干活！
You need to have [.NET Framework 4.5](http://www.microsoft.com/en-us/download/details.aspx?id=30653) installed for your version of Windows. Those on Windows 8 do not have to do this.

#### 我是Windows XP/Mac/Linux系统但我也想拿这个艹船！
Sadly, Microsoft doesn't fully support .NET 4.5. There may be 3rd party ways of getting support for the package, but Microsoft has basically abandoned the XP and other OSs in terms of support. Your only two choices realistically is to either get to Windows 7/8 or use [Logbook](https://github.com/Zharay/logbook) which is another Kancolle project that is being worked on that uses Java and is multi-platform also being worked on by [@Zharay](http://twitter.com/Zharay). It is much simpler, but does an awesome job at what it does.

####我白屏了/我报错无法连接。
Please let me know if this is happening and tell me what OS you are using and the version of IE. My suspicion is an outdated version of IE. Reports have also shown that clearing your cache+cookies and re-installing flash will also fix this issue.

If you are getting connection errors, try changing the program's proxy server port within KanColleViewer.exe.config. Find the number 37564 and replace it with 37565 or another random number. Restart KCV and see if the problem goes away.

#### 我的舰队和远征信息不会刷新!
Clear your cache and relaunch KCV again. Especially after updates or playing between versions of KCV, this should fix any issues regarding this.

#### 我想让船名装备名之类的显示成日文。
Easiest way is to just disable translations in the options menu. You can also set the UI's language to Japanese which will disable all translations by default. If you only want certain things translated, deleting the corresponding XML file in the translation folder is your best bet (just be sure to disable auto update).

#### 我看不懂XXX（XXX还没翻译！）
Please help me with these when you run into them. The translation engine has the ability to add untranslated text to the corresponding XML file found in translations. Find the untranslated parts at the bottom of the list and message it to me as a bug in GitHub.

#### 就算我换了语言可船名物品名还是英文！
I no longer support multi-language translations. If you want to use translation from another fork, in file KanColleViewer.exe.config, just copy KCVUpdateUrl's value from another fork and paste to KCVUpdateTransUrl's value (not KCVUpdateUrl). Then go to setting/update and click "Force download" button. Depend on version and another fork, translation may be supported or not.

####自定义通知音是什么鬼？
These are sounds that play immediately when a normal windows notification is to be displayed. Supported formats are WAV and MP3. You must place them in the "Sounds" and under the sub-directory corresponding to the notification you require. It doesn't matter the name or the number you have; a random file will be chosen to be played every time.

Note! For those not in English UI, you may need to place them in the folders that are generated *after* a notification is played once. Any missing folders will be created for you.

#### 这货和Grabarc07的原版KCV有什么区别吗?
* 可横屏竖屏切换
* 物品，任务，远征，船名都有翻译
* 可查看装备信息
* 可查看排名信息
* 肝船计算器
* 记录检视
* 自动检查更新
* 可以通过设置Cookies直连
* 可改变Flash画质来提升渣性能下的流畅度
* 可自定义声音提醒
* 可记录掉落建造

Other than the above, this version is the same with some tweaks to make it fit for an English translation. The plan is to hopefully add some features into the main project for all to enjoy.

## 关于项目
KanColleViewer uses the web browser component of the Windows Presentation Foundation (WPF) in combination of [FiddlerCore](http://fiddler2.com/fiddlercore) to capture communication packets in-between the server and the page itself.

Of course, we do not change the contents of the packets in anyway and is used to provide information to the program's components.

### 关于翻译
Main work on the translation of ships, equipment, and quests fall solely on the now defunct [silfumus' version of KanColleViewer](https://github.com/silfumus/KanColleViewer) and those who contributed to it. Zharay manually merged the changes to this version of the fork and went from there.

The way the translation works is that it manually loads the translation from several text files which holds both the Japanese name and the English translation of the item in question. This can theoretically be used to translate the contents of the game easily to any language needed.

### 主要特点
* Real-time display of elements such as instant repair and build materials.
* Real-time display of the number of Ship Girls and equipment held at the HQ
* List of all ship girls currently in your fleets
* Repair and Construction end timers and notifications.
* List of all quests currently active as well as a listing of available daily and weekly quests.
* Screenshot saving
* Sound muting

### 环境要求
* Windows 8 或更高
* Windows 7 (需要手动安装支持库)
* [.NET Framework 4.5](http://www.microsoft.com/ja-jp/download/details.aspx?id=30653)

Developed and tested mainly in Windows 8.1 Pro. Windows 7 can also be used to run the program, but you will not have the built in notification system that is found in Windows 8. 

Windows 7 requires that you install .NET Framework 4.5. Windows 8 already has this installed by default.

### 开发环境、语言、库。
This was mainly developed using C# + WPF in Windows 8.1 Pro and Visual Studio Premium 2013.

* [Reactive Extensions](http://rx.codeplex.com/)
* Interactive Extensions
* [Windows API Code Pack](http://archive.msdn.microsoft.com/WindowsAPICodePack)
* [Livet](http://ugaya40.net/livet) (MVVM Infrastructure)
* [DynamicJson](http://dynamicjson.codeplex.com/) (JSON deserialization processing)
* [FiddlerCore](http://fiddler2.com/fiddlercore) (Network capture)


#### 许可协议
* MIT License

遵循MIT license作为开源、免费软件发行。
