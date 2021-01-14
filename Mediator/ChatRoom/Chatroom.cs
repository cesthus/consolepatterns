using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ChatRoom
{
    /// <summary>
    /// The concrete mediator class
    /// </summary>
    public class Chatroom : AbstractChatroom
    {
        private Dictionary<string, Participant> _participant = new Dictionary<string, Participant>();


        public override void Register(Participant participant)
        {
            if (!_participant.ContainsValue(participant))
            {
                _participant[participant.Name] = participant;
            }
            participant.Chatroom = this;
        }

        public override void Send(string from, string to, string message)
        {
            Participant participant = _participant[to];
            if(participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}
