using System;
using RealmAddressBook.Models;
using System.Collections.Generic;

namespace RealmAddressBook.Services
{
    public interface IDBService
    {
        bool SavePerson (string id, string firstName, string lastName);

        bool SaveAddress (string personId, string street, string suiteApartment, string city, string zip, string state);

        List<Person> GetPeople ();

        List<Person> SearchPeople (string searchText);

        Person GetPersonById (string id);


        void DeletePerson (string iD);
    }
}

