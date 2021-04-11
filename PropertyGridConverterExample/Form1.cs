using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
