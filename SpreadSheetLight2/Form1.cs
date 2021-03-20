using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpreadSheetLight2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WriteButton.Enabled = false;

            if (!ExcelOperations.FileExist)
            {
                ReadButton.Enabled = false;
            }
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            var dt = ExcelOperations.Read();
            if (ExcelOperations.Exception == null)
            {
                dataGridView1.DataSource = dt;
                WriteButton.Enabled = true;
            }
            else
            {
                MessageBox.Show(ExcelOperations.Exception.Message);
            }

        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            var dt = (DataTable) dataGridView1.DataSource;

            MessageBox.Show(ExcelOperations.Write(dt) ? 
                "Updated" : 
                ExcelOperations.Exception.Message);
        }
    }
}
