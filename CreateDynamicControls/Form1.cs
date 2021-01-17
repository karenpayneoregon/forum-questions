using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using CreateDynamicControls.Classes;
using CreateDynamicControls.Classes.Controls;

namespace CreateDynamicControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Operations.Initialize(this,10,30, 10,100, CategoryButtonClick);
            
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
        private void CategoryButtonClick(object sender, EventArgs e)
        {
            var button = (DataButton)sender;
            //MessageBox.Show($"Id: {button.Identifier} - Category: {button.Text}");
            var products = DataOperations.ReadProducts(button.Identifier);
            MessageBox.Show(products.Count.ToString());
        }

        private void ButtonListButton_Click(object sender, EventArgs e)
        {
            ButtonsListBox.DataSource = Operations.ButtonsList.Select(button => button.Name).ToList();
        }

        private void CreateCategoryButtons_Click(object sender, EventArgs e)
        {
            foreach (var category in DataOperations.ReadCategories())
            {
                Operations.CreateCategoryButton(category.Name, category.Id);
            }
        }
    }


}
