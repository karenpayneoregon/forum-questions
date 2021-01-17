using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using CreateDynamicControls.Classes;

namespace CreateDynamicControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Operations.Initialize(this,10,30, 100,100, GenericButtonClick);
            
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            
            Operations.CreateButton(string.IsNullOrWhiteSpace(ButtonTextButton.Text) ? "(empty)" : ButtonTextButton.Text);
            
        }

        private void GenericButtonClick(object sender, EventArgs e)
        {
            var button = (Button) sender;
            MessageBox.Show(button.Name);
        }

        private void ButtonListButton_Click(object sender, EventArgs e)
        {
            ButtonsListBox.DataSource = Operations.ButtonsList.Select(button => button.Name).ToList();
        }
    }


}
