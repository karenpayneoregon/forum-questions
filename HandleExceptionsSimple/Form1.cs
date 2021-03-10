using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandleExceptionsSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Logger.CreateLog();
            Logger.Info("Application started.", "Main");
            Logger.EmptyLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var ooops = (ListBox) sender;
            }
            catch (Exception exception)
            {
                Logger.Exception(exception);
                Logger.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var fileContents = File.ReadAllLines("NonExistingFile.txt");
            }
            catch (Exception exception)
            {
                Logger.Exception(exception);
                Logger.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var (lines, success, exception) = ReadSomeFile();
            if (success)
            {
                foreach (var line in lines)
                {
                    
                }
            }
            else
            {
                MessageBox.Show($@"Encountered issues {exception.Message}");
            }
        }

        private (List<string> lines, bool success, Exception exception) ReadSomeFile()
        {
            List<string> contents = new List<string>();

            try
            {
                var fileContents = File.ReadAllLines("NonExistingFile.txt");
                return (lines: contents, success: false, exception: null);
            }
            catch (Exception ex)
            {
                return (lines: contents, success: false, exception: ex);
            }

        }
    }
}
