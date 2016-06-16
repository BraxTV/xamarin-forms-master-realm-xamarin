using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

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

        public ICommand SaveCommand { get; set; }

        public AddEditAddressViewModel ()
        {
            SaveCommand = new Command (() => DoSave ());
        }

        void DoSave ()
        {
            throw new NotImplementedException ();
        }
    }
}