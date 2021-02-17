using System;
using System.Windows.Forms;

namespace OleDbConnectionUpdateData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            DataOperations.OnExceptionEvent += OnExceptionEvent;
            DataOperations.OnFinishedEvent += OnFinishedEvent;
        }

        private void OnFinishedEvent()
        {
            
        }

        private void OnExceptionEvent(Exception sender)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var result = await DataOperations.PerformUpdateTask();
            if (result)
            {
                
            }
            else
            {
                
            }
        }
    }
}
