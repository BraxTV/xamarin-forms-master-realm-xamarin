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

       
        private string searchText;

        public string SearchText
        {
            get
            {
                return searchText;
            }
            set
            {
                searchText = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SearchText"));
                People = new ObservableCollection<Person>(DBService.SearchPeople(searchText));
            }
        }

        protected IDBService DBService;

        public PeopleListViewModel(IDBService dbService)
        {
            DBService = dbService;
            Init();
        }

        public void Init()
        {
            People = new ObservableCollection<Person>(DBService.GetPeople());
        }
    }
}

