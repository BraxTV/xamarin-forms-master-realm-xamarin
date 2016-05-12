using System;
using System.Collections.Generic;
using RealmAddressBook.Models;
using Realms;
using System.Linq;

namespace RealmAddressBook.Services
{
    public class RealmDBService:IDBService
    {
        protected Realm RealmInstance;

        public RealmDBService()
        {
            RealmInstance = Realm.GetInstance();
        }

        #region IDBService implementation

        public bool SavePerson(string firstName, string lastName)
        {
            try
            {
                RealmInstance.Write(() =>
                    {
                        var person = RealmInstance.CreateObject<Person>();
                        person.FirstName = firstName;
                        person.LastName = lastName;
                    });

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Person> GetPeople()
        {
            return RealmInstance.All<Person>().ToList();
        }

        #endregion

       
    }
}

