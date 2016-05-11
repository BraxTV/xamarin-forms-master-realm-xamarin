using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using RealmAddressBook.Models;
using Xamarin.Forms;
using RealmAddressBook.Services;

namespace RealmAddressBook.ViewModels
{
    public class PeopleListViewModel:INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        #endregion


        private ObservableCollection<Person> people;

        public ObservableCollection<Person> People
        {
            get
            {
                return people;
            }
            set
            {
                people = value;
                PropertyChanged(this, new PropertyChangedEventArgs("People"));
            }
        }

        protected IDBService DBService;

        public PeopleListViewModel(IDBService dbService)
        {
            DBService = dbService;
        }
    }
}

