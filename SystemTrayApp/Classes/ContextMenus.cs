using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using SystemTrayApp.Forms;
using SystemTrayApp.Properties;

namespace SystemTrayApp.Classes
{
	class ContextMenus
	{

		private bool _isViewWindowLoaded = false;

		/// <summary>
		/// Creates this instance.
		/// </summary>
		/// <returns>ContextMenuStrip</returns>
		public ContextMenuStrip Create()
		{

			var menu = new ContextMenuStrip();
			ToolStripMenuItem mainToolStripMenuItem;
			ToolStripSeparator menuSeparator;

            mainToolStripMenuItem = new ToolStripMenuItem
            {
                Text = @"Explorer",
                Image = Resources.WinFolder
            };

            mainToolStripMenuItem.Click += Explorer_Click;

			menu.Items.Add(mainToolStripMenuItem);

            mainToolStripMenuItem = new ToolStripMenuItem
            {
                Text = @"View",
                Image = Resources.About
            };

            mainToolStripMenuItem.Click += ViewWindow_Click;
			menu.Items.Add(mainToolStripMenuItem);

            menuSeparator = new ToolStripSeparator();
			menu.Items.Add(menuSeparator);


            mainToolStripMenuItem = new ToolStripMenuItem
            {
                Text = @"Exit",
                Image = Resources.Exit

            };

            mainToolStripMenuItem.Click += Exit_Click;
			menu.Items.Add(mainToolStripMenuItem);

			return menu;

		}

		/// <summary>
		/// Handles the Click event of the Explorer control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		void Explorer_Click(object sender, EventArgs e)
        {
            var targetPathWatched = ConfigurationManager.AppSettings["WatchFolder"]; ;

            if (Directory.Exists(targetPathWatched))
            {
                Process.Start(targetPathWatched);
            }
            else
            {
                Process.Start("explorer", null);
            }
        }
		void ViewWindow_Click(object sender, EventArgs e)
		{
            if (_isViewWindowLoaded) return;

            _isViewWindowLoaded = true;
            new ViewerForm().ShowDialog();
            _isViewWindowLoaded = false;

        }

		/// <summary>
		/// Processes a menu item.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		void Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}