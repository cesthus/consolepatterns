using Observer.ConcreteObserver;
using Observer.ConcreteSubject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            GClooney gClooney = new GClooney("First tweet, I love my wife");
            TSwift tSwift  = new TSwift("Second tweet, I love my wife");

            Fan firstFan = new Fan("Roger");
            Fan secondFan = new Fan("Samuel");

            gClooney.AddFollower(firstFan);
            gClooney.AddFollower(secondFan);

            tSwift.AddFollower(secondFan);

            gClooney.Tweet = "My Wife does not love me";
            tSwift.Tweet = "I do love music";

            Console.ReadKey();
        }
    }
}
