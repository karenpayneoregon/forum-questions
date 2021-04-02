using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyChangeProgressBar
{
    public partial class Form1 : Form, INotifyPropertyChanged
    {
        private int _percentDone = 50;
        public Form1()
        {
            InitializeComponent();
            
            progressBar1.Maximum = 100;

            progressBar1.DataBindings.Add("Value", this, "PercentDone");
        }
        public int PercentDone
        {
            get => _percentDone;
            set
            {
                _percentDone = value;
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
