﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ReservationDemo.Classes
{
    public class SeatTable
    {
        /// <summary>
        /// Primary key to database table
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Seat row to combine with Number property
        /// </summary>
        public string Row { get; set; }
        /// <summary>
        /// Number on row to be combined when displaying with Row property
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Is this seat available
        /// </summary>
        public bool Available { get; set; }
        /// <summary>
        /// For debugging
        /// </summary>
        /// <returns>Id, Row, Number properties</returns>
        public override string ToString() => $"{Id}, {Row}{Number}";

    }

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
