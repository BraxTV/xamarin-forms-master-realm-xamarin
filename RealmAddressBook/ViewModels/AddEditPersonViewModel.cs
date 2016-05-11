using System;
using System.ComponentModel;
using RealmAddressBook.Services;
using RealmAddressBook.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace RealmAddressBook.ViewModels
{
    public class AddEditPersonViewModel:INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        #endregion




        public string FirstName
        {
            get
            {
                return Model.FirstName;
            }
            set
            {
                Model.FirstName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("FirstName"));
            }
        }



        public string LastName
        {
            get
            {
                return Model.LastName;
            }
            set
            {
                Model.LastName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("LastName"));
            }
        }

        protected IDBService DBService;

        protected Person Model = new Person();

        public ICommand SaveCommand{ get; set; }

        public AddEditPersonViewModel(IDBService dbService)
        {
            DBService = dbService;
            SaveCommand = new Command(o => DBService.SavePerson(Model));

        }
    }
}

