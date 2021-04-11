using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PropertyGridConverterExample.Classes
{
    public class Person : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phone;

        //[RefreshProperties(RefreshProperties.All)]
        [Description("The person's first or given name")]
        [Category("Name")]
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        [Description("The person's last or family name")]
        [Category("Name")]
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        [Description("The person's street address")]
        [Category("Contact Info")]
        public StreetAddress Address { get; set; }

        [Description("The person's primary email address")]
        [Category("Contact Info")]
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        [Description("The person's business phone number")]
        [Category("Contact Info")]
        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }

        // Return the Person as a string for display purposes.
        public override string ToString() => FirstName + " " + LastName;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
