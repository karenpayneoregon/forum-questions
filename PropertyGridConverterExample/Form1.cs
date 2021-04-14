using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyGridConverterExample.Classes;

namespace PropertyGridConverterExample
{
    public partial class Form1 : Form
    {
        private BindingList<Person> _personList = new BindingList<Person>();
        private BindingSource _personBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            lstPeople.SelectedIndexChanged += LstPeopleOnSelectedIndexChanged;
        }

        private void LstPeopleOnSelectedIndexChanged(object? sender, EventArgs e)
        {
            // Reset the DisplayMember to make
            // the ListBox refresh its list.
            lstPeople.DisplayMember = "FirstName";
            lstPeople.DisplayMember = null;

            // Display the selected Person in the PropertyGrid.
            pgdPeople.SelectedObject = lstPeople.SelectedItem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person[] people =
            {
                new Person() {
                    FirstName="Ann", LastName="Archer",
                    Address=new StreetAddress(){Street="101 Ash Ave", City="Ann Arbor", State="MI", Zip="12345"},
                    Email="Ann@anywhere.com", Phone="703-287-3798"},
                new Person() {
                    FirstName="Ben", LastName="Best",
                    Address=new StreetAddress() {Street="231 Beach Blvd", City="Boulder", State="CO", Zip="24361"},
                    Email="Ben@bestplace.com", Phone="209-783-2918"},
                new Person() {
                    FirstName="Cindy", LastName="Carter",
                    Address=new StreetAddress() {Street="3783 Cherry Ct", City="Cedar Rapids", State="IA", Zip="36268"},
                    Email="CindyCarter@TheCarters.com", Phone="404-329-0182"},
            };

            _personList = new BindingList<Person>(people);
            _personBindingSource.DataSource = _personList;

            // Display them in a ListBox.
            lstPeople.DataSource = _personBindingSource;
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            var person = _personList[lstPeople.SelectedIndex];
            Console.WriteLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt.Columns.Add("COL1", typeof(string));
            Dt.Columns.Add("COL2", typeof(string));
            Dt.Columns.Add("COL3", typeof(string));
            Dt.Rows.Add("101", "XZ", "101XZ");
            Dt.Rows.Add("101", "XY", "XY101");
            Dt.Rows.Add("101", "ZZ", "101 ZZ");
            Dt.Rows.Add("101", "ZZ", "101 ZZ");

            var results = Dt
                .AsEnumerable()
                .Select((row, index) => new { Row = row, Index = index })
                .Where(item => item.Row.Field<string>("COL3")
                    .Contains(" "))
                .ToList();

            if (results.Count > 0)
            {
                foreach (var x in results)
                {
                    if (x.Row["COL3"] != DBNull.Value)
                    {
                        Debug.WriteLine($"{x.Index}, '{x.Row.Field<string>("COL3")}'");
                    }
                }
            }
            
            DataTable dtQty = new DataTable();
var Qtyvalues = dtQty
    .AsEnumerable()
    .Where(x => x["COL3"] != DBNull.Value)
    .Select(p => p.Field<string>("QTY"));


        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> listValues = new()
            {
                "E-10-XN-PP",
                "E-10-XN-MM",
                "E-10-XN-NM"
            };

            HashSet<string> hashSet = new();
            listValues.ForEach(item => hashSet.Add(item));
            Debug.WriteLine(hashSet.Count == listValues.Count);

            var hasDuplicatedEntries = listValues.GroupBy(value => value).Any(@group => @group.Count() > 1);
            Debug.WriteLine(hasDuplicatedEntries);
        }

        private async void checkAddressStatusButton_Click(object sender, EventArgs e)
        {

            var webAddress = "https://stackoverflowNotHere.com/";

            checkAddressStatusButton.Enabled = false;
            try
            {
                var results = await CheckUrlStatus(webAddress);
                MessageBox.Show(results ? "Is valid" : "Is not valid");
            }
            finally
            {
                checkAddressStatusButton.Enabled = true;
            }
        }



        public static async Task<bool> CheckUrlStatus(string website)
        {
            return await Task.Run(async () =>
            {
                await Task.Delay(1);
                try
                {
                    var request = WebRequest.Create(website) as HttpWebRequest;
                    request.Method = "HEAD";
                    using var response = (HttpWebResponse)request.GetResponse();

                    return response.StatusCode == HttpStatusCode.OK;
                }
                catch
                {
                    return false;
                }
            });

        }
    }

    public static class Extensions
    {
        public static bool HasDuplications(this List<string> sender) => sender.GroupBy(value => value).Any(@group => @group.Count() > 1);

        public static string ToYesNoString(this bool value) => value ? "Yes" : "No";
    }
}
