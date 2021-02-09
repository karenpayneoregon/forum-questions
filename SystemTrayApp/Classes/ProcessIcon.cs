using System;
using System.Windows.Forms;
using SystemTrayApp.Forms;
using SystemTrayApp.Properties;

namespace SystemTrayApp.Classes
{
	/// <summary>
	/// 
	/// </summary>
	class ProcessIcon : IDisposable
	{
        private readonly NotifyIcon _notifyIcon;

		public ProcessIcon()
		{
			_notifyIcon = new NotifyIcon();
            _notifyIcon.DoubleClick += _notifyIcon_DoubleClick;
        }

        public void RemoveIcon()
        {
            _notifyIcon.Visible = false;
            _notifyIcon.Icon = null;
            _notifyIcon.Dispose();
        }

        /// <summary>
        /// Do something when double clicking the tray icon, circumvents
        /// _notifyIcon_MouseClick which has been commented out but left to
        /// show possibilities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            var viewForm = new ViewerForm();
            try
            {
                if (viewForm.ShowDialog() == DialogResult.OK)
                {
                    // do something
                }
                else
                {
                    // do not perform any positive actions
                }
            }
            finally
            {
                viewForm.Dispose();
            }
        }

        /// <summary>
        /// Displays the icon in the system tray.
        /// </summary>
        public void Display()
		{
			_notifyIcon.MouseClick += _notifyIcon_MouseClick;
			_notifyIcon.Icon = Resources.main;
			_notifyIcon.Text = @"System Tray Utility Application Demonstration";
			_notifyIcon.Visible = true;

			_notifyIcon.ContextMenuStrip = new ContextMenus().Create();
		}

		public void Dispose()
		{
			_notifyIcon.Dispose();
		}

        /// <summary>
        /// Handles the MouseClick event of the _notifyIcon control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void _notifyIcon_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				//Process.Start("explorer", null);
			}
		}
	}
}