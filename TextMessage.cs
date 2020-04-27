using System;
using System.Collections.Generic;
using System.Text;

namespace Whatsapp
{
    class TextMessage : Message
    {
        public int NumChar;

        public TextMessage(Contact ContactTo, string SendTime, string Content) : base(ContactTo, SendTime, Content)
        {
            this.NumChar = 0;
        }

        //public override void nametoString()
        //{

        //    Console.WriteLine("Q2 = " + this.NumChar);
        //}
    }
}
