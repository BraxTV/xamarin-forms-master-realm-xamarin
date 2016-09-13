using System;
using Realms;

namespace RealmAddressBook.Models
{
    public class Person : RealmObject
    {

        [ObjectId]
        public string ID { get; set; }

        public string FirstName {
            get;
            set;
        }

        public string LastName {
            get;
            set;
        }



        public string FullName {
            get {
                return string.Format ("{0} {1}", FirstName, LastName);
            }
        }

        public RealmList<Address> Addresses {
            get;

        }

        public Person ()
        {
        }
    }
}

