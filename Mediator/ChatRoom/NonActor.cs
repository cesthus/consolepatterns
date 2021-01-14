using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ChatRoom
{
    /// <summary>
    /// Concrete colleague class
    /// </summary>
    public class NonActor : Participant
    {
        public NonActor(string name): base(name) { }

        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Actor: ");
            base.Receive(from, message);
        }
    }
}
