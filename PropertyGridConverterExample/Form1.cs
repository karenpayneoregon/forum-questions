using System.ComponentModel;
using PropertyGridConverterExample.Classes;

namespace PropertyGridConverterExample;

public partial class Form1 : Form
{
    private BindingList<Person> _personList = [];
    private BindingSource _personBindingSource = [];
    public Form1()
    {
        InitializeComponent();

        PeopleListBox.SelectedIndexChanged += PeopleOnSelectedIndexChanged;
    }

    private void PeopleOnSelectedIndexChanged(object? sender, EventArgs e)
    {
        // Reset the DisplayMember to make
        // the ListBox refresh its list.
        PeopleListBox.DisplayMember = "FirstName";
        PeopleListBox.DisplayMember = null!;

        // Display the selected Person in the PropertyGrid.
        PeopleGrid.SelectedObject = PeopleListBox.SelectedItem;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Person[] people =
        [
            new() {
                FirstName = "Ann", LastName = "Archer",
                Address = new StreetAddress() {Street = "101 Ash Ave", City = "Ann Arbor", State = "MI", Zip = "12345"},
                Email = "Ann@anywhere.com", Phone = "703-287-3798"},
            new() {
                FirstName = "Ben", LastName = "Best",
                Address = new StreetAddress() { Street = "231 Beach Blvd", City = "Boulder", State = "CO", Zip = "24361"},
                Email = "Ben@bestplace.com", Phone = "209-783-2918"},
            new() {
                FirstName = "Cindy", LastName = "Carter",
                Address = new StreetAddress() { Street = "3783 Cherry Ct", City = "Cedar Rapids", State = "IA", Zip = "36268"},
                Email = "CindyCarter@TheCarters.com", Phone = "404-329-0182"}
        ];

        _personList = new BindingList<Person>(people);
        _personBindingSource.DataSource = _personList;

        // Display them in a ListBox.
        PeopleListBox.DataSource = _personBindingSource;
    }

    private void CurrentButton_Click(object sender, EventArgs e)
    {
        Person person = _personList[PeopleListBox.SelectedIndex];
        MessageBox.Show($"{person.FirstName} {person.LastName}");
    }

}