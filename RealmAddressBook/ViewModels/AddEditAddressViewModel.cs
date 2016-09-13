using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using RealmAddressBook.Services;

namespace RealmAddressBook.ViewModels
{
    public class AddEditAddressViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public string Street {
            get;
            set;
        }

        public string SuiteApartment {
            get;
            set;
        }

        public string City {
            get;
            set;
        }

        public string Zip {
            get;
            set;
        }

        public string State {
            get;
            set;
        }


        readonly IDBService DBService;

        public ICommand SaveCommand { get; set; }

        protected string PersonId;

        public AddEditAddressViewModel (IDBService dbService)
        {
            SaveCommand = new Command (() => DoSave ());
            DBService = dbService;
        }

        public void Init (string personId)
        {
            PersonId = personId;
        }

        void DoSave ()
        {
            DBService.SaveAddress (PersonId, Street, SuiteApartment, City, Zip, State);
        }
    }
}