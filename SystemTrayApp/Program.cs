using System;
using System.Diagnostics;
using System.Windows.Forms;
using SystemTrayApp.Classes;

namespace SystemTrayApp
{
	static class Program
    {
        private static ProcessIcon _processIcon;

        public static TextWriterTraceListener applicationListener = new TextWriterTraceListener(
            "SystemTrayLog.log", 
            "PayneListener");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main()
		{

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            applicationListener.WriteLine($"Starting up: {DateTime.Now}");
            applicationListener.Flush();

            Application.ApplicationExit += Application_ApplicationExit;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            
            WatchOperations.Instance.TraceListener = applicationListener;
            WatchOperations.Instance.EnableWatch();


   //         using (var processIcon = new ProcessIcon())
			//{
			//	processIcon.Display();
			//	Application.Run();
			//}

            _processIcon = new ProcessIcon();
            _processIcon.Display();
            Application.Run();


        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                // ReSharper disable once PossibleNullReferenceException
                applicationListener.WriteLine($"Unhandled exception: {DateTime.Now} - {(e.ExceptionObject as Exception).Message}");
            }
            catch (Exception)
            {
                // we are not in a position to do anything here so we accept this and exit the application
            }
        }
        /// <summary>
        /// Responsible to write log data to disk it there are any lines not flushed
        /// along with disabling the singleton watcher.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            applicationListener.WriteLine($"Closing: {DateTime.Now}");
            applicationListener.Flush();

            WatchOperations.Instance.DisableWatch();

            _processIcon.RemoveIcon();
        }
    }
}