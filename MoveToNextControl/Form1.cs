using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoveToNextControl.Extensions;
using UtilityLibrary;

namespace MoveToNextControl
{
    public partial class Form1 : Form
    {
        private double fee_double;

        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.KeyDown += (s, ea) =>
                    {
                        if (ea.KeyCode != Keys.Enter) return;
                        
                        ea.SuppressKeyPress = true;
                        SelectNextControl(ActiveControl, true, true, true, true);
                    };
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var invoiceNumber = "A10000";
            
            for (int index = 0; index < 10; index++)
            {
                invoiceNumber = StringHelpers.IncrementAlphaNumericValue(invoiceNumber);
                Debug.WriteLine(invoiceNumber);
            }

        }

        private void TestCheckedButton_Click(object sender, EventArgs e)
        {
            if(postonly_check.Checked)
            {
                fee_double = 0.025;
                Debug.WriteLine("Is");
            }
            else
            {
                Debug.WriteLine("Not");
            }
        }
    }
}
