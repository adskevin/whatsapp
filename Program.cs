using System;

namespace Whatsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Contact contact1 = new Contact("Ronaldo!", "5959595959");
            Console.WriteLine(contact1.name);

            Contact contact2 = new Contact("Vanessa", "4848484848");
            Console.WriteLine(contact2.name);

            Contact contact3 = new Contact("Reginalda", "12121212");
            Console.WriteLine(contact3.name);

            Contact contact4 = new Contact("Lucas", "25252525");
            Console.WriteLine(contact4.name);

            Contact contact5 = new Contact("Virajuva", "35353535");
            Console.WriteLine(contact5.name);

            string nowTime = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            TextMessage msg1 = new TextMessage(contact2, nowTime, "Olá, eu sou o Ronaldo, me add aí.");
            TextMessage msg2 = new TextMessage(contact2, nowTime, "Não me ignora não.");
            TextMessage msg3 = new TextMessage(contact2, nowTime, "Sei que tu entrou no Whats.");

            //Console.WriteLine(msg1.Content);
            //Console.WriteLine(msg2.Content);
            //Console.WriteLine(msg3.Content);

            Whatsapp whats = new Whatsapp();

            whats.ContactList[0] = contact3;
            whats.ContactList[1] = contact4;
            whats.ContactList[2] = contact5;

            whats.ListContacts();

            whats.MessageList[0] = msg1;
            whats.MessageList[1] = msg2;
            whats.MessageList[2] = msg3;

            whats.ListContacts();

        }
    }
}
