using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UnboundDataGridViewComboBox
{
    public partial class Form1 : Form
    {
        private AutoCompleteStringCollection _autoList = 
            new AutoCompleteStringCollection();
        
        private ComboBox _cbo;
        private string _comboColumnName = "C1";
        
        public Form1()
        {
            InitializeComponent();
            
            DataGridView1.CellLeave += DataGridView1OnCellLeave;
            DataGridView1.EditingControlShowing += DataGridView1OnEditingControlShowing;
        }

        private void DataGridView1OnEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (!DataGridView1.CurrentCell.IsComboBoxCell()) return;

            if (DataGridView1.Columns[DataGridView1.CurrentCell.ColumnIndex].Name != _comboColumnName) return;
            
            _cbo = e.Control as ComboBox;
            _cbo.DropDownStyle = ComboBoxStyle.DropDown;
            _cbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _cbo.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void DataGridView1OnCellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (_cbo == null) return;
            if (string.IsNullOrWhiteSpace(_cbo.Text)) return;
            
            if (!_autoList.Contains(_cbo.Text))
            {
                var cb = (DataGridViewComboBoxColumn)DataGridView1.Columns[0];
                _autoList.Add(_cbo.Text);
                var items = ((string[])cb.DataSource).ToList();
                items.Add(_cbo.Text);
                var index = items.FindIndex((x) => x.ToLower() == _cbo.Text.ToLower());
                cb.DataSource = items.ToArray();
                _cbo.SelectedIndex = index;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var source = new[] { "Add", "Subtract", "Divide", "Multiply" };

            var column1 = new DataGridViewComboBoxColumn
            {
                DataSource = source,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                Name = _comboColumnName,
                HeaderText = "Demo",
                SortMode = DataGridViewColumnSortMode.NotSortable
            };

            var column2 = new DataGridViewCheckBoxColumn
            {
                Name = "C2",
                HeaderText = "Col 2"
            };
            var column3 = new DataGridViewTextBoxColumn
            {
                Name = "C3",
                HeaderText = "Col 3"
            };

            _autoList.AddRange(source);

            DataGridView1.Columns.AddRange(column1, column2, column3);

            DataGridView1.Rows.Add("Divide", true, "Karen");
            DataGridView1.Rows.Add("Add", false, "Kevin");
            DataGridView1.Rows.Add("Subtract", true, "Anne");
            DataGridView1.Rows.Add("Add", true, "Joe");
            DataGridView1.Rows.Add("Multiply", true, "Jean");

		}

        private void AddNewRowButton_Click(object sender, EventArgs e)
        {
            DataGridView1.Rows.Add("Subtract", true, "Wendy");
        }
    }
}
