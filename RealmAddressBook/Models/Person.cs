using System;
using Realms;

namespace RealmAddressBook.Models
{
    public class Person:RealmObject
    {

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }

        public Person()
        {
        }
    }
}

