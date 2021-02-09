﻿

using System.IO;
using System.Linq;
using System.Windows.Forms;
using SystemTrayApp.Classes;
using static System.DateTime;

namespace SystemTrayApp.Forms
{
    public partial class ViewerForm : Form
    {
        public ViewerForm()
        {
            InitializeComponent();

            Shown += ViewerForm_Shown;

            WatchOperations.Instance.FileSystemWatcher.Created += FileCreated;
            WatchOperations.Instance.FileSystemWatcher.Renamed += FileRenamed;

        }

        private void ViewerForm_Shown(object sender, System.EventArgs e)
        {
            if (WatchFileContainer.Instance.NewFileList.Any(item => !item.Processed))
            {
                foreach (var fileContainer in WatchFileContainer.Instance.NewFileList)
                {
                    ResultsListView.Items.Add(new ListViewItem(new[]
                    {
                        fileContainer.Action, fileContainer.Message, fileContainer.EventTime
                    }));
                }
            }
        }

        /// <summary>
        /// Monitor file rename operations. Since the FileSystemWatcher is in another
        /// thread Invoke is required to prevent cross thread violations between threads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileRenamed(object sender, RenamedEventArgs e)
        {

            if (ResultsListView.InvokeRequired)
            {
                Invoke((MethodInvoker)(() =>
                    ResultsListView.Items.Add(new ListViewItem(new[]
                    {
                        "Renamed", $"{e.OldName} to {e.Name}", Now.ToString("yyyy/MM/dd HH:mm:ss")
                    }))));

                ResizeSetFocus();

            }
        }

        private void FileCreated(object sender, FileSystemEventArgs e)
        {

            WatchFileContainer.Instance.NewFileList.Add(new FileContainer()
            {
                Processed = false,
                Action = "Created",
                Message = $"{e.Name}",
                EventTime = Now.ToString("yyyy/MM/dd HH:mm:ss")
            });


            if (ResultsListView.InvokeRequired)
            {

                Invoke((MethodInvoker)(() =>
                   ResultsListView.Items.Add(new ListViewItem(new[]
                   {
                        "Created", $"{e.Name}", Now.ToString("yyyy/MM/dd HH:mm:ss")
                   })))
               );


            }

            ResizeSetFocus();

        }

        private void ResizeSetFocus()
        {
            if (ResultsListView.Items.Count <= 0) return;

            Invoke((MethodInvoker)
                (
                    () =>
                        {
                            ResultsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                            ResultsListView.EndUpdate();
                            ResultsListView.FocusedItem = ResultsListView.Items[ResultsListView.Items.Count - 1];
                            ResultsListView.Items[ResultsListView.Items.Count - 1].Selected = true;
                            ActiveControl = ResultsListView;
                        }
                    ));

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var test = WatchFileContainer.Instance.NewFileList.Count;
            MessageBox.Show(test.ToString());
        }
    }
}
