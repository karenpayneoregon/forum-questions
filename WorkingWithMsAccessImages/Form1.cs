using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WorkingWithMsAccessImages.Classes;

namespace WorkingWithMsAccessImages
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            
            _bindingSource.PositionChanged += BindingSourceOnPositionChanged;
            
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            var ops = new Operations();
            
            _bindingSource.DataSource = ops.PictureDataTable;
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.ExpandColumns();
        }

        private void BindingSourceOnPositionChanged(object sender, EventArgs e)
        {
            if (_bindingSource.Current != null)
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(
                    ((DataRowView)_bindingSource.Current).Row.Field<byte[]>("Picture")));

            }
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            var ops = new Operations();

            var results = ops.AddImage("ErrorForm.png", 0, "Test");
            if (results.Success)
            {
                var values = ops.LoadSingleImage(results.Identifier);
                var table = (DataTable) _bindingSource.DataSource;
                table.Rows.Add(results.Identifier, 0, results.ImageBytes);
                _bindingSource.MoveLast();
            }
            else
            {
                MessageBox.Show(!string.IsNullOrWhiteSpace(results.ErrorMessage) ? 
                    $"Failed to add image\n{results.ErrorMessage}" : 
                    "Failed to add image\n");
            }
        }
    }
}
