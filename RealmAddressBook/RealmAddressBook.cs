using System;

using Xamarin.Forms;
using RealmAddressBook.Pages;
using RealmAddressBook.ViewModels;

namespace RealmAddressBook
{
    public class App : Application
    {

        public static ViewModelLocator VMLocator = new ViewModelLocator();

        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new PeoplePage()){ BarBackgroundColor = Color.FromHex("#8b7dbe"), BarTextColor = Color.White };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

