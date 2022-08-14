
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewCombo1.Classes;

namespace DataGridViewCombo1
{
    public partial class Form1 : Form
    {
        readonly Operations _operations = new Operations();

        readonly BindingSource _productBindingSource = new BindingSource();
        readonly BindingSource _vendorBindingSource = new BindingSource(); 
        readonly BindingSource _colorBindingSource = new BindingSource(); 

        public Form1()
        {
            InitializeComponent();

            ProductsDataGridView.CurrentCellDirtyStateChanged += _CurrentCellDirtyStateChanged;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Setup();

            ProductsDataGridView.AllowUserToAddRows = false ;
            _productBindingSource.PositionChanged += _customerBindingSource_PositionChanged;

            LoadData();
            CurrentValuesView();

            ActiveControl = ProductsDataGridView;

        }

        private void _customerBindingSource_PositionChanged(object sender, EventArgs e)
        {
            CurrentValuesView();
        }

        private void Setup()
        {

            _operations.LoadColorsReferenceDataTable();
            _operations.LoadVendorsReferenceDataTable();

            _vendorBindingSource.DataSource = _operations.VendorDataTable;
            _colorBindingSource.DataSource = _operations.ColorDataTable;

            ColorComboBoxColumn.DisplayMember = "ColorText";
            ColorComboBoxColumn.ValueMember = "ColorId";
            ColorComboBoxColumn.DataPropertyName = "ColorId";
            ColorComboBoxColumn.DataSource = _colorBindingSource;
            ColorComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            ColorComboBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;

            VendorComboBoxColumn.DisplayMember = "VendorName";
            VendorComboBoxColumn.ValueMember = "VendorId";
            VendorComboBoxColumn.DataPropertyName = "VendorId";
            VendorComboBoxColumn.DataSource = _vendorBindingSource;
            VendorComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            VendorComboBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;

            QtyNumericUpDownColumn.DataPropertyName = "qty";
            InCartCheckBoxColumn.DataPropertyName = "InCart";

        }
        private void LoadData()
        {

            _operations.LoadProductDataTable();

            ProductsDataGridView.AutoGenerateColumns = false;

            ItemTextBoxColumn.DataPropertyName = "Item";
            _productBindingSource.DataSource = _operations.ProductDataTable;

            ProductsDataGridView.DataSource = _productBindingSource;

        }

        private void _CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            ProductsDataGridView.CurrentCellDirtyStateChanged -= _CurrentCellDirtyStateChanged;
            ProductsDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            ProductsDataGridView.CurrentCellDirtyStateChanged += _CurrentCellDirtyStateChanged;
        }
       
        private void CurrentValuesView()
        {

            if (_productBindingSource.Current == null)
            {
                return;
            }

            #region Get primary table information

            var productRow = ((DataRowView)_productBindingSource.Current).Row;
            var customerPrimaryKey = productRow.Field<int>("Id");
            var colorKey = productRow.Field<int>("ColorId");
            var vendorKey = productRow.Field<int>("VendorId");

            #endregion

            #region Get child table information

            // ReSharper disable once AssignNullToNotNullAttribute
            var vendorName = ((DataTable)_vendorBindingSource.DataSource)
                .AsEnumerable()
                .FirstOrDefault(row => row.Field<int>("VendorId") == vendorKey)
                .Field<string>("VendorName");

            // ReSharper disable once AssignNullToNotNullAttribute
            var colorName = ((DataTable)_colorBindingSource.DataSource)
                .AsEnumerable()
                .FirstOrDefault(row => row.Field<int>("ColorId") == colorKey)
                .Field<string>("ColorText");

            #endregion


            DisplayInformationTextBox.Text =
                // ReSharper disable once LocalizableElement
                $"PK: {customerPrimaryKey} Vendor key {vendorKey} vendor: {vendorName} color id: {colorKey} - {colorName}";
        }
    }
}

