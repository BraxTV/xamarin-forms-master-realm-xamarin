using System;
using RealmAddressBook.Models;
using System.Collections.Generic;

namespace RealmAddressBook.Services
{
    public interface IDBService
    {
        bool SavePerson(string id, string firstName, string lastName);

        List<Person> GetPeople();

        List<Person> SearchPeople(string searchText);


    }
}

