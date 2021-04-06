using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CheckedListBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            checkedListBox1.Items.AddRange(new object[] 
                { "FirstName", "LastName", "Street", "City", "Country" });
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            var results = checkedListBox1.CheckedStringList();
            if (results.Count == 0)
            {
                MessageBox.Show("Nothing selected");
            }
            else
            {

                MessageBox.Show(string.Join("\n", results.ToArray()));
            }
        }

        private void CheckItButton_Click(object sender, EventArgs e)
        {
            checkedListBox1.FindItemAndSetChecked("City", checkBox1.Checked);
        }
    }
    /// <summary>
    /// Place in a class file
    /// </summary>
	public static class ExtensionMethods
    {

        public static List<string> CheckedStringList(this CheckedListBox sender) => 
            sender.Items.Cast<string>().Where((item, index) => 
                sender.GetItemChecked(index)).Select(item => item).ToList();

        public static void FindItemAndSetChecked(this CheckedListBox sender, string valueToLocate, bool checkedState = true)
        {

            var result = (sender.Items.Cast<string>().Select((item, index) => new {Item = item, Index = index}).Where(@this => @this.Item == valueToLocate)).FirstOrDefault();

            if (result != null)
            {
                sender.SetItemChecked(result.Index, checkedState);
            }

        }
    }


}
