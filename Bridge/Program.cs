using Bridge.MessageSender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender text = new TextSender();
            IMessageSender web = new WebServiceSender();

            Message msg = new SystemMessage();
            msg.Subject = "First Message";
            msg.Body = "Please accept this message";

            msg.MessageSender = text;
            msg.Send();

            msg.MessageSender = web;
            msg.Send();

            Console.ReadKey();
        }
    }
}
