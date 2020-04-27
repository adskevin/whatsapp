using System;
using System.Collections.Generic;
using System.Text;

namespace Whatsapp
{
    abstract class Message
    {
        public Contact ContactTo { set; get; }
        public string SendTime { set; get; }
        public string Content { set; get; }

        public Message(Contact ContactTo, string SendTime, string Content)
        {
            this.ContactTo = ContactTo;
            this.SendTime = SendTime;
            this.Content = Content;
        }

        //abstract public void nametoString();
    }
}
