using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using ChangeImage.Properties;

namespace ChangeImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void OpenFormButton_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            
            form2.OnChangeImage += Form2OnChangeImage;
            form2.OnChangeImageByName += Form2OnChangeImageByName;
            
            form2.Show();
        }

        private void Form2OnChangeImageByName(string name)
        {


            pictureBox1.Image = Resources.ResourceManager.GetObject(name) is Icon ? 
                ((Icon) Resources.ResourceManager.GetObject(name))?.ToBitmap() : 
                (Bitmap) Resources.ResourceManager.GetObject(name);

        }

        private void Form2OnChangeImage(Bitmap image)
        {
            pictureBox1.Image = image;
        }
    }
}
