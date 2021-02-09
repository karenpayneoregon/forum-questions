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

namespace Access_mdb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            var cb = new ComboBox()
            {
                Left = 10, 
                Top = 10, 
                DataSource = DataOperations.Read()
            };
            
            Controls.Add(cb);
        }

        private void ReadTextFileButton_Click(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/4063685/using-oledbconnection-to-read-tab-separated-file
            dataGridView1.DataSource = DataOperations.ReadTextFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Data.txt", File.ReadAllText("Data.txt"), Encoding.Default);
        }
    }
}
