using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProcessingAndWait
{
    public partial class Form1 : Form
    {
        private string _fileName = "ipPower.txt";
        public Form1()
        {
            InitializeComponent();

            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            PowerShellScriptExecute();
        }

        public void PowerShellScriptExecute()
        {
            var start = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                Arguments = "Invoke-RestMethod ipinfo.io/ip", 
                CreateNoWindow = true
            };

            using var process = Process.Start(start);
            using var reader = process.StandardOutput;
            process.EnableRaisingEvents = true;
            var ipAddressResult = reader.ReadToEnd();
            File.WriteAllText(_fileName, ipAddressResult);

            process.WaitForExitAsync();
            
            // executes after the WaitForExitAsync is done
            Debug.WriteLine(File.ReadAllText(_fileName));
        }
     
    }
    /// <summary>
    /// Place in a separate file
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Async wait for process to complete
        /// </summary>
        /// <param name="process">Process to wait for</param>
        /// <param name="cancellationToken">Optional cancellation token if the process was lengthy</param>
        /// <returns></returns>
        public static Task WaitForExitAsync(this Process process, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (process.HasExited)
            {
                return Task.CompletedTask;
            }

            var tcs = new TaskCompletionSource<object>();
            
            process.EnableRaisingEvents = true;
            process.Exited += (sender, args) => tcs.TrySetResult(null);

            if (cancellationToken != default)
            {
                cancellationToken.Register(() => tcs.SetCanceled());
            }

            return process.HasExited ? Task.CompletedTask : tcs.Task;
        }
    }
}
