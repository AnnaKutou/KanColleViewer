using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Threading.Tasks;
using Grabacr07.KanColleViewer.Composition;
using Grabacr07.KanColleViewer.Plugins.ViewModels;
using Grabacr07.KanColleViewer.Plugins.Views;

namespace Grabacr07.KanColleViewer.Plugins
{
	[Export(typeof(IToolPlugin))]
	[ExportMetadata("Title", "LogViewer")]
    [ExportMetadata("Description", "呈现捞取・建造·开发记录")]
	[ExportMetadata("Version", "1.1")]
	[ExportMetadata("Author", "+PaddyXu")]
	public class LogViewer : IToolPlugin
	{
		private readonly PortalViewModel logViewerViewModel = new PortalViewModel();

		public string ToolName
		{
            get { return "记录检视"; }
		}


		public object GetSettingsView()
		{
			return null;
		}

		public object GetToolView()
		{
			return new Portal { DataContext = this.logViewerViewModel };
		}
	}
}
