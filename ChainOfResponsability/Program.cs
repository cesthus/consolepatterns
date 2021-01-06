using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setup
            Approver ronny = new Director();
            Approver bob = new VicePresident();
            Approver rick = new President();

            ronny.SetSuccessor(bob);
            bob.SetSuccessor(rick);

            //Process
            Purchase p1 = new Purchase(8883, 499, "Assets");
            ronny.ProcessRequest(p1);

            p1 = new Purchase(3344, 20000, "Project main");
            ronny.ProcessRequest(p1);

            p1 = new Purchase(3554, 89000, "Project BPO");
            ronny.ProcessRequest(p1);

            Console.ReadKey();
        }
    }
}
