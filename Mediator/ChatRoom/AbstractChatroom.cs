using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ChatRoom
{
    /// <summary>
    /// Mediator abstrac
    /// </summary>
    public abstract class AbstractChatroom
    {
        public abstract void register(Participant participant);
        public abstract void register(string from, string to, string messafe);
    }
}
