using System;
using RealmAddressBook.Services;

namespace RealmAddressBook.ViewModels
{
    public static class ViewModelLocator
    {

        public static PeopleListViewModel PeopleListVM{ get; set; }

        public static AddEditPersonViewModel AddEditPersonVM{ get; set; }

        static ViewModelLocator()
        {
            var dbServiceToUse = new RealmDBService();
            PeopleListVM = new PeopleListViewModel(dbServiceToUse);
            AddEditPersonVM = new AddEditPersonViewModel(dbServiceToUse);
        }
    }
}

