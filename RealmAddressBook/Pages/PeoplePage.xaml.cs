using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

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
    }
}

