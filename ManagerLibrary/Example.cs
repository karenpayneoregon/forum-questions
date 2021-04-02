using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ManagerLibrary
{
    public class Example : INotifyPropertyChanged
    {
        private  int _startValue;
        private  int _endValue;

        public delegate void OnProcessingCompleted(WhatEver sender);
        public static event OnProcessingCompleted OnProcessingCompletedEvent;

        public  int StartValue
        {
            get => _startValue;
            set
            {
                _startValue = value;
                OnPropertyChanged();
            }
        }

        public int EndValue
        {
            get => _endValue;
            set
            {
                _endValue = value;
                OnPropertyChanged();
            }
        }

        public  void DoWork()
        {

            OnProcessingCompletedEvent?.Invoke(new WhatEver()
            {
                StartLockDownCount = StartValue,
                EndLockDownCount = 10
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
