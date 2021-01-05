using Observer.Observer;
using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.ConcreteObserver
{
    public class Fan : IFan
    {
        private string _name;
        public Fan(string name)
        {
            _name = name;
        }
        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"{_name} => Fan notified. Tweet of {celebrity.FullName}: "+
                $"{celebrity.Tweet}");
        }
    }
}
