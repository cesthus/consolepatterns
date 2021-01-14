using Mediator.ChatRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Chatroom chatroom = new Chatroom();
            Participant roy = new Actor("Roy");
            Participant sandra = new Actor("Sandra");
            Participant tony = new NonActor("Tony");
            Participant tom = new NonActor("Tom");

            chatroom.Register(roy);
            chatroom.Register(sandra);
            chatroom.Register(tony);
            chatroom.Register(tom);

            //chat
            tony.Send("Tom", "Hi there");
            sandra.Send("Roy", "Teach me to act");
            roy.Send("Tony", "See you later!");

            Console.ReadKey();
        }
    }
}
