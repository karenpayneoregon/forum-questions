using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void productsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            var test = northWindDataSet.Tables["Products"].GetChanges(DataRowState.Deleted);
            //var deletedTable = this.customerTableAdapter.Tables["Customer"].GetChanges(DataRowState.Deleted); 
            if (test == null)
            {
                
            }
            //this.tableAdapterManager.UpdateAll(this.northWindDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northWindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northWindDataSet.Products);
            productsDataGridView.Rows.RemoveAt(0);

        }
    }
}
