using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SystemTrayApp.Classes
{
    /// <summary>
    /// Responsible for watching file operations in a specific folder.
    ///
    /// If when an event like file creation occurs and after processing the file it
    /// needs to be moved make sure to first execute <see cref="EnableWatch()"/>, perform
    /// the move then execute <see cref="DisableWatch()"/>
    /// </summary>
    /// <remarks>
    /// Thread safe Singleton class
    /// See also
    /// Lazy https://docs.microsoft.com/en-us/dotnet/api/system.lazy-1?view=netframework-4.8
    /// </remarks>
    public sealed class WatchOperations : IDisposable
    {
        private static readonly Lazy<WatchOperations> Lazy =
            new Lazy<WatchOperations>(() => new WatchOperations());

        public static WatchOperations Instance => Lazy.Value;

        /*
         * Folder to watch, taken from app.config
         */
        private string _folderName;

        public FileSystemWatcher FileSystemWatcher;

        /*
         * This is set in Program.cs for writing diagnostics to a text log file.
         */
        public TextWriterTraceListener TraceListener;

        /// <summary>
        /// Enable FileSystemWatcher to monitor folder
        /// </summary>
        public void EnableWatch() => FileSystemWatcher.EnableRaisingEvents = true;
        /// <summary>
        /// Disable FileSystemWatcher from monitor folder
        /// </summary>
        public void DisableWatch() => FileSystemWatcher.EnableRaisingEvents = false;

        /// <summary>
        /// Create a instance of FileSystemWatcher with filters
        /// and events to react to file operations in path pasted in
        /// to this constructor.
        /// </summary>
        /// <remarks>
        /// Must be protected/private
        /// </remarks>
        private WatchOperations()
        {
            _folderName = ConfigurationManager.AppSettings["WatchFolder"];

            NewFileList = new List<string>();

            if (!Directory.Exists( _folderName))
            {
                throw new Exception("Watch folder does not exist, alter WatchFolder setting in app.config");
            }

            FileSystemWatcher = new FileSystemWatcher(_folderName)
            {
                Filter = ConfigurationManager.AppSettings["FileFilter"],
                /*
                 * Add or remove filters here
                 */
                NotifyFilter =   NotifyFilters.LastAccess
                               | NotifyFilters.LastWrite
                               | NotifyFilters.FileName
                               | NotifyFilters.DirectoryName
                
            };

            /*
             * Subscribe to trigger events which in this case write to the log file
             */
            FileSystemWatcher.Changed += OnChanged;
            FileSystemWatcher.Created += OnCreated;
            FileSystemWatcher.Renamed += OnRenamed;
        }
       
        /// <summary>
        /// Fired when a file is renamed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            TraceListener.WriteLine($"Rename: {e.OldName}, {e.Name}");
        }

        public List<string> NewFileList { get; set; }
        /// <summary>
        /// Fired when a file is created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            
            //TraceListener.WriteLine($"Created: {e.Name}");
            
            if (!NewFileList.Contains(e.Name))
            {
                NewFileList.Add(e.Name);
                AutoClosingMessageBox.Show(text: $"Created: {e.Name}", caption: "New zip file", timeout: 10000);
            }
        }
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            TraceListener.WriteLine($"Changed: {e.Name}");
        }
        /// <summary>
        /// Destroy watcher which stops any events from being triggered
        /// </summary>
        public void Dispose()
        {
            FileSystemWatcher?.Dispose();
        }
    }
}
