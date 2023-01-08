using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _title = "Roster App";
        public string Title
        {
            get => _title; set
            {
                if (value != _title)
                {
                    _title = value;
                }
            }
        }

        public Command UpdateApplicationCommand { get; set; }
    }
}
