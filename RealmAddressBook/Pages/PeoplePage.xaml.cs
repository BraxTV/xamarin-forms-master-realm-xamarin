using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;
using RealmAddressBook.ViewModels;

namespace RealmAddressBook.Pages
{
    public partial class PeoplePage : ContentPage
    {
        public PeoplePage()
        {
            InitializeComponent();
            ToolbarItems.Add(new ToolbarItem("Add", null, async () => await GoPersonPage()));
        }

        protected async Task GoPersonPage()
        {
            await this.Navigation.PushAsync(new PersonPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext != null)
                (BindingContext as PeopleListViewModel).Init();
        }
    }
}

