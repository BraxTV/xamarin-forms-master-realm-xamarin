using System;
using RealmAddressBook.Services;

namespace RealmAddressBook.ViewModels
{
    public class ViewModelLocator
    {

        public PeopleListViewModel PeopleListVM { get; set; }

        public AddEditPersonViewModel AddEditPersonVM { get; set; }

        public AddEditAddressViewModel AddEditAddressVM { get; set; }

        public ViewModelLocator ()
        {
            var dbServiceToUse = new RealmDBService ();
            PeopleListVM = new PeopleListViewModel (dbServiceToUse);
            AddEditPersonVM = new AddEditPersonViewModel (dbServiceToUse);
            AddEditAddressVM = new AddEditAddressViewModel ();
        }
    }
}

