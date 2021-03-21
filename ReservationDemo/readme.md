# About

Code sample for forum question. 

:green_circle: Run database script or adjust to meet seat requirements

:green_circle: Review code in SqlOperations

:yellow_circle: Data operations exception handled not done




# Control update

- Added INotifyPropertyChanged for update notification
- Added SeatTable class for interactions between form, classes and database

```csharp
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ControlLibrary
{
    public class SeatPictureBox : PictureBox, INotifyPropertyChanged
    {
        private bool _available;
        public int Id { get; set; }
        public string Row { get; set; }
        public int Number { get; set; }
        public string Seat => $"{Row}{Number}";

        public bool Available
        {
            get => _available;
            set
            {
                _available = value;
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
```
