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

        public bool SavePerson(string id, string firstName, string lastName)
        {
            try
            {
                RealmInstance.Write(() =>
                    {
                        var person = RealmInstance.CreateObject<Person>();
                        person.ID = id;
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

        public List<Person> SearchPeople(string searchText)
        {
            return RealmInstance.All<Person>().Where(p => p.FirstName.Contains(searchText) || p.LastName.Contains(searchText)).ToList();
        }

       
        public Person GetPersonById(string id)
        {
            return GetPeople().FirstOrDefault(p => p.ID == id);
        }

        public void DeletePerson(string id)
        {
            using (var trans = RealmInstance.BeginWrite())
            {
                RealmInstance.Remove(GetPersonById(id));
                trans.Commit();
            }

        }
    }
}

