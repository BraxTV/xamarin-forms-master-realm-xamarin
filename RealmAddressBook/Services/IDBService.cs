using System;
using RealmAddressBook.Models;
using System.Collections.Generic;

namespace RealmAddressBook.Services
{
    public interface IDBService
    {
        bool SavePerson(Person person);

        List<Person> GetPeople();
    }
}

