using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.MessageSender
{
    /// <summary>
    /// Bridge/implementor class
    /// </summary>
    public interface IMessageSender
    {
        void SendMessage(string subjet, string body);
    }
}
