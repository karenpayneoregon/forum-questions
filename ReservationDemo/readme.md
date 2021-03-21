# About

Code sample for forum question. 

:green_circle: Run database script or adjust to meet seat requirements

:green_circle: Review code in SqlOperations

:yellow_circle: Data operations exception handled not done


![net](assets/NetVersions.png)

# Control update

- Added [INotifyPropertyChanged](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged?view=net-5.0) for update notification
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

### Container for data operations

```csharp
public class SeatTable
{
    public int Id { get; set; }
    public string Row { get; set; }
    public int Number { get; set; }
    public bool Available { get; set; }
    /// <summary>
    /// For debugging
    /// </summary>
    /// <returns>Id, Row, Number properties</returns>
    public override string ToString() => $"{Id}, {Row}{Number}";

}
```