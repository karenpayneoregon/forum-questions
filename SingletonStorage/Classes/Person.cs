using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace SingletonStorage.Classes
{
    public class Person : INotifyPropertyChanged
    {
        private int _personIdentifier;
        private string _firstName;
        private string _lastName;

        public int PersonIdentifier
        {
            get => _personIdentifier;
            set
            {
                _personIdentifier = value;
                OnPropertyChanged();
            }
        }
        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 3)]
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }
        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 6)]
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// Person's address details
        /// </summary>
        public Address Address { get; set; }

        public Person()
        {
            Address = new Address();
        }

        public override string ToString() => $"{FirstName} {LastName}";
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
