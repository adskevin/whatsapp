using System;
using System.Collections.Generic;
using System.Text;

namespace Whatsapp
{
    class Contact
    {
        public string name { get; set; }
        public string phoneNumber { get; set; }

        public Contact(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public Contact()
        {

        }
    }
}
