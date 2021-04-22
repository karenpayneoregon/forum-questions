using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SimpleJsonExample1
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            if (!File.Exists(Operations.FileName))
            {
                Operations.SaveMockup();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _bindingSource.DataSource = Operations.Read();
            bindingNavigator1.BindingSource = _bindingSource;
            
            
            CheckBoxItem.DataBindings.Add("Checked", _bindingSource, "CheckboxValue");
            
            IdLabel.DataBindings.Add("Text", _bindingSource, "Id");
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            var current = (ListItem) _bindingSource.Current;
            MessageBox.Show(current.CheckboxValue.ToString());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Operations.Save((List<ListItem>) _bindingSource.DataSource);
        }
    }
}
