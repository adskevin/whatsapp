using System;
using System.Collections.Generic;
using System.Text;

namespace Whatsapp
{
    class Whatsapp
    {
        public Contact[] ContactList { set; get; }
        public Message[] MessageList { set; get; }

        public Whatsapp()
        {
            this.ContactList = new Contact[10];
            this.MessageList = new Message[10];
        }

        public void ListContacts()
        {
            Console.WriteLine(this.ContactList[0].name);
            Console.WriteLine(this.ContactList[1].name);
            Console.WriteLine(this.ContactList[2].name);

            //foreach (Contact oneContact in ContactList)
            //{
            //    Console.Write(oneContact.ToString());
            //}
        }
    }
}
