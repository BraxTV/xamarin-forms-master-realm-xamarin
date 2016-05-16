using System;
using System.Collections.Generic;

using Xamarin.Forms;
using RealmAddressBook.ViewModels;

namespace RealmAddressBook.Pages
{
    public partial class PersonPage : ContentPage
    {
        protected string PersonId;

        
        public PersonPage(string id)
        {
            PersonId = id;
            InitializeComponent();
        }


        public PersonPage()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            if (this.BindingContext != null)
                (BindingContext as AddEditPersonViewModel).Init(PersonId);
        }

    }
}

