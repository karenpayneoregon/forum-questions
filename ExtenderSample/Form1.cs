using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtenderSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(controlExtender1.GetCustom1(textBox1));
            //controlExtender1.SetCustom1(textBox1,"New value");
            //MessageBox.Show(controlExtender1.GetCustom1(textBox1));

            //var id = textBox1.Identifier();


            if (textBox1.HasIdentifier())
            {
                MessageBox.Show($"Identifier is {textBox1.Identifier()}");
            }
            else
            {
                MessageBox.Show("Identifier not set or not a integer");
            }

            

        }
    }
}
