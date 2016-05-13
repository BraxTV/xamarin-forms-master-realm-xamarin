using System;
using System.Collections.Generic;

using Xamarin.Forms;
using RealmAddressBook.ViewModels;

namespace RealmAddressBook.Pages
{
    public partial class PersonPage : ContentPage
    {
        protected string PersonId;

        protected string FirstName;

        protected string LastName;

        public PersonPage(string id, string firstName, string lastName)
        {
            this.PersonId = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            InitializeComponent();
        }

        public PersonPage()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            var vm = BindingContext as AddEditPersonViewModel;
            if (string.IsNullOrEmpty(PersonId))
            {
                vm.Id = Guid.NewGuid().ToString();
            }
            else
            {
                vm.Id = PersonId;
                vm.FirstName = FirstName;
                vm.LastName = LastName;
            }
        }
    }
}

