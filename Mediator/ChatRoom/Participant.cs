using System;

namespace Mediator.ChatRoom
{
    /// <summary>
    /// The abstract colleague class
    /// </summary>
    public class Participant
    {
        private Chatroom _chatroom;
        private string _name;

        public Participant(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public Chatroom Chatroom
        {
            set { _chatroom = value; }
            get { return _chatroom; }
        }

        // Send message to given participant
        public void Send(string to, string message)
        {
            _chatroom.Send(_name, to, message);
        }

        //Receives message from given participant
        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }

    }
}