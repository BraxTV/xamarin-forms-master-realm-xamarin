using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;
using RealmAddressBook.ViewModels;
using RealmAddressBook.Models;

namespace RealmAddressBook.Pages
{
    public partial class PeoplePage : ContentPage
    {
        public PeoplePage ()
        {
            InitializeComponent ();
            ToolbarItems.Add (new ToolbarItem ("Add", null, async () => await GoPersonPage ()));
            ListView.ItemTapped += async (object sender, ItemTappedEventArgs e) => {
                Person p = e.Item as Person;
                await this.Navigation.PushAsync (new PersonPage (p.ID));
            };


        }

        protected async Task GoPersonPage ()
        {
            await this.Navigation.PushAsync (new PersonPage ());
        }

        protected override void OnAppearing ()
        {
            base.OnAppearing ();
            if (BindingContext != null)
                (BindingContext as PeopleListViewModel).Init ();
        }
    }
}

