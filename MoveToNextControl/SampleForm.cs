using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoveToNextControl
{
    public partial class SampleForm : Form
    {
        public SampleForm()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object? sender, EventArgs e)
        {
            tabControl1.SelectedIndexChanged += TabControl1OnSelectedIndexChanged;
            Selected();
        }

        private void TabControl1OnSelectedIndexChanged(object? sender, EventArgs e)
        {
            Selected();
        }

        private void Selected()
        {
            DataGridView dgv = tabControl1.SelectedIndex switch
            {
                0 => tabControl1.TabPages[0].Controls.OfType<DataGridView>().FirstOrDefault(),
                1 => tabControl1.TabPages[1].Controls.OfType<DataGridView>().FirstOrDefault(),
                2 => tabControl1.TabPages[2].Controls.OfType<DataGridView>().FirstOrDefault(),
                _ => null
            };

            if (dgv is null)
            {
                MessageBox.Show("Failed to find");
            }
            else
            {
                if (dgv.CurrentRow != null)
                {
                    var value = dgv.Rows[dgv.CurrentRow.Index].Cells[dgv.CurrentCell.ColumnIndex].Value.ToString();
                }
            }
        }
    }
}
