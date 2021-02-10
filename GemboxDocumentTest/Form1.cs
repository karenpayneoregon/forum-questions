using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemboxDocumentTest.Classes;

namespace GemboxDocumentTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Example1Button_Click(object sender, EventArgs e)
        {
            Operations.Example1();
            MessageBox.Show("Done");
        }
    }
}
