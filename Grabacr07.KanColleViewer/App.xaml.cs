﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Grabacr07.KanColleViewer.Models;
using Grabacr07.KanColleViewer.ViewModels;
using Grabacr07.KanColleViewer.Views;
using Grabacr07.KanColleWrapper;
using Livet;
using MetroRadiance;
using AppSettings = Grabacr07.KanColleViewer.Properties.Settings;
using Settings = Grabacr07.KanColleViewer.Models.Settings;

namespace Grabacr07.KanColleViewer
{
	public partial class App
	{
		public static ProductInfo ProductInfo { get; private set; }
		public static MainWindowViewModel ViewModelRoot { get; private set; }

		static App()
		{
			AppDomain.CurrentDomain.UnhandledException += (sender, args) => ReportException(sender, args.ExceptionObject as Exception);
		}

		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			this.DispatcherUnhandledException += (sender, args) => ReportException(sender, args.Exception);

			DispatcherHelper.UIDispatcher = this.Dispatcher;
			ProductInfo = new ProductInfo();

			Settings.Load();
			WindowsNotification.Notifier.Initialize();
			Helper.SetRegistryFeatureBrowserEmulation();

			KanColleClient.Current.Proxy.Startup(AppSettings.Default.LocalProxyPort);
			KanColleClient.Current.Proxy.UseProxyOnConnect = Settings.Current.EnableProxy;
			KanColleClient.Current.Proxy.UseProxyOnSSLConnect = Settings.Current.EnableSSLProxy;
			KanColleClient.Current.Proxy.UpstreamProxyHost = Settings.Current.ProxyHost;
			KanColleClient.Current.Proxy.UpstreamProxyPort = Settings.Current.ProxyPort;

            KanColleClient.Current.Homeport.Translations.EnableTranslations = Settings.Current.EnableTranslations;
            KanColleClient.Current.Homeport.Translations.EnableAddUntranslated = Settings.Current.EnableAddUntranslated;

			ResourceService.Current.ChangeCulture(Settings.Current.Culture);
            KanColleClient.Current.Homeport.Translations.ChangeCulture(Settings.Current.Culture);

            KanColleClient.Current.Homeport.Translations.Firepower = Grabacr07.KanColleViewer.Properties.Resources.Stats_Firepower;
            KanColleClient.Current.Homeport.Translations.AntiAir = Grabacr07.KanColleViewer.Properties.Resources.Stats_AntiAir;
            KanColleClient.Current.Homeport.Translations.Accuracy = Grabacr07.KanColleViewer.Properties.Resources.Stats_Accuracy;
            KanColleClient.Current.Homeport.Translations.Torpedo = Grabacr07.KanColleViewer.Properties.Resources.Stats_Torpedo;
            KanColleClient.Current.Homeport.Translations.AntiSub = Grabacr07.KanColleViewer.Properties.Resources.Stats_AntiSub;
            KanColleClient.Current.Homeport.Translations.Evasion = Grabacr07.KanColleViewer.Properties.Resources.Stats_Evasion;
            KanColleClient.Current.Homeport.Translations.SightRange = Grabacr07.KanColleViewer.Properties.Resources.Stats_SightRange;
            KanColleClient.Current.Homeport.Translations.Luck = Grabacr07.KanColleViewer.Properties.Resources.Stats_Luck;
            KanColleClient.Current.Homeport.Translations.Speed = Grabacr07.KanColleViewer.Properties.Resources.Stats_Speed;
            KanColleClient.Current.Homeport.Translations.Armor = Grabacr07.KanColleViewer.Properties.Resources.Stats_Armor;
            KanColleClient.Current.Homeport.Translations.Health = Grabacr07.KanColleViewer.Properties.Resources.Stats_Health;
            KanColleClient.Current.Homeport.Translations.AttackRange = Grabacr07.KanColleViewer.Properties.Resources.Stats_AttackRange;
            KanColleClient.Current.Homeport.Translations.DiveBomb = Grabacr07.KanColleViewer.Properties.Resources.Stats_DiveBomb;

            KanColleClient.Current.Homeport.Logger.EnableLogging = Settings.Current.EnableLogging;

			ThemeService.Current.Initialize(this, Theme.Dark, Accent.Purple);

			ViewModelRoot = new MainWindowViewModel();
			this.MainWindow = new MainWindow { DataContext = ViewModelRoot };
			this.MainWindow.Show();
		}

		protected override void OnExit(ExitEventArgs e)
		{
			base.OnExit(e);

			KanColleClient.Current.Proxy.Shutdown();

			WindowsNotification.Notifier.Dispose();
			Settings.Current.Save();
		}


		private static void ReportException(object sender, Exception exception)
		{
			#region const
			const string messageFormat = @"
===========================================================
ERROR, date = {0}, sender = {1},
{2}
";
			const string path = "error.log";
			#endregion

			try
			{
				var message = string.Format(messageFormat, DateTimeOffset.Now, sender, exception);

				Debug.WriteLine(message);
				File.AppendAllText(path, message);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
		}
	}
}
