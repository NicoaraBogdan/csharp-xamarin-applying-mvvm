using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Roster.Client.Models;
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
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Title)));
                }
            }
        }

        public ObservableCollection<Person> People { get; set; }

        public Command UpdateApplicationCommand { get; set; }

        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(() =>
            {
                Title = "Roster App (v2.0)";
            });

            People = new ObservableCollection<Person>();
            People.Add(new Person { Name = "Delores Feil", Company = "Legros Group" });
            People.Add(new Person { Name = "Ann Zboncak", Company = "Ledner - Ferry" });
            People.Add(new Person { Name = "Jaime Lesch", Company = "Herzog and Sons" });
        }

    }
}
