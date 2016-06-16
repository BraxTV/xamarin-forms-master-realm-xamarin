using System;
using Realms;
namespace RealmAddressBook.Models
{
    public class Address : RealmObject
    {
        [ObjectId]
        public string ID { get; set; }

        public string Street {
            get;
            set;
        }

        public string SuiteApartment {
            get;
            set;
        }

        public string City {
            get;
            set;
        }

        public string Zip {
            get;
            set;
        }

        public string State {
            get;
            set;
        }



        public Address ()
        {
        }
    }
}

