using System;
using System.Collections.Generic;
using RealmAddressBook.Models;

namespace RealmAddressBook.Services
{
    public class RealmDBService:IDBService
    {
        public RealmDBService()
        {
        }

        #region IDBService implementation

        public bool SavePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetPeople()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

