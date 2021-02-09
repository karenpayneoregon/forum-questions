﻿using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using ChangeImage.Properties;

namespace ChangeImage
{
    public partial class Form2 : Form
    {
        public delegate void ChangeImage(Bitmap image);
        public event ChangeImage OnChangeImage;
        public delegate void ChangeImageByName(string name);
        public event ChangeImageByName OnChangeImageByName;
        
        
        
        public Form2()
        {
            InitializeComponent();
            GetImageNames();
        }

        private void GetImageNames()
        {
            var resourceSet = Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            foreach (var entry in resourceSet.OfType<DictionaryEntry>().Select((item, i) => new { Index = i, Key = item.Key, Value = item.Value }))
            {
                listBox1.Items.Add(entry.Key);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnChangeImage?.Invoke(Properties.Resources.Miata1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnChangeImage?.Invoke(Properties.Resources.Miata2);
        }

        private void ChangeImageByNameButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                OnChangeImageByName?.Invoke(listBox1.Text);
            }
            else
            {
                MessageBox.Show("Select a car");
            }
            
        }
    }
}
