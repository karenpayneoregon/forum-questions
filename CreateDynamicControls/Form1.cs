﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using CreateDynamicControls.Classes;
using CreateDynamicControls.Classes.Containers;
using CreateDynamicControls.Classes.Controls;

namespace CreateDynamicControls
{
    public partial class Form1 : Form
    {
        private BindingList<Product> _productsBindingList;
        private readonly BindingSource _productBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            Operations.Initialize(this,20,30, 10,100, CategoryButtonClick);
            ProductsListBox.DoubleClick += ProductsListBoxOnDoubleClick;

        }
        /// <summary>
        /// Access current product id and name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductsListBoxOnDoubleClick(object sender, EventArgs e)
        {
            if (_productBindingSource.Current == null)
            {
                return;
            }

            var product = (Product) _productBindingSource.Current;

            MessageBox.Show($"{product.Id}, {product.Name}");
        }

        private void CreateButtonClick(object sender, EventArgs e)
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
            
            _productsBindingList = new BindingList<Product>(DataOperations.ReadProducts(button.Identifier));
            _productBindingSource.DataSource = _productsBindingList;
            ProductsListBox.DataSource = _productBindingSource;


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
