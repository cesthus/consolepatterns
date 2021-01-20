using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.MessageSender
{
    /// <summary>
    /// Concrete implementor
    /// </summary>
    public class WebServiceSender : IMessageSender
    {
        public void SendMessage(string subjet, string body)
        {
            Console.WriteLine("Message type: Web Service");
            Console.WriteLine($"Subject: {subjet} from Web Service Body: {body}");
        }
    }
}
