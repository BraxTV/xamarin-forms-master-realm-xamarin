using System;
using System.ComponentModel;
using RealmAddressBook.Services;
using RealmAddressBook.Models;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.Generic;

namespace RealmAddressBook.ViewModels
{
    public class AddEditPersonViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        #endregion



        private string firstName;

        public string FirstName {
            get {
                return firstName;
            }
            set {
                firstName = value;
                PropertyChanged (this, new PropertyChangedEventArgs ("FirstName"));
            }
        }


        private string lastName;

        public string LastName {
            get {
                return lastName;
            }
            set {
                lastName = value;
                PropertyChanged (this, new PropertyChangedEventArgs ("LastName"));
            }
        }

        private List<Address> addresses;

        public List<Address> Addresses {
            get {
                return addresses;
            }
            set {
                Addresses = value;
                PropertyChanged (this, new PropertyChangedEventArgs ("Addresses"));
            }
        }

        protected IDBService DBService;

        protected Person Model = new Person ();

        public ICommand SaveCommand { get; set; }

        public ICommand DeleteCommand { get; set; }

        public AddEditPersonViewModel (IDBService dbService)
        {
            DBService = dbService;
            SaveCommand = new Command (() => DoSave ());
            DeleteCommand = new Command (() => DoDelete ());

        }


        public void Init (string id)
        {
            Model = id != null ? DBService.GetPersonById (id) : new Person () {
                ID = Guid.NewGuid ().ToString ()
            };
            FirstName = Model.FirstName;
            LastName = Model.LastName;


        }

        protected void DoSave ()
        {
            DBService.SavePerson (Model.ID, FirstName, LastName);
        }

        protected void DoDelete ()
        {
            DBService.DeletePerson (Model.ID);
        }
    }
}

