using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ReservationDemo.Classes
{
    public class ExcelItem : INotifyPropertyChanged
    {
        private string _column1;
        private int _column2;

        public string Column1
        {
            get => _column1;
            set
            {
                _column1 = value;
                OnPropertyChanged();
            }
        }

        public int Column2
        {
            get => _column2;
            set
            {
                _column2 = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}