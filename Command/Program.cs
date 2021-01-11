using Command.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Compute('+', 100);
            user.Compute('-', 10);
            user.Compute('*', 5);
            user.Compute('/', 3);

            //undo
            user.Undo(4);

            //redo
            user.Redo(3);

            Console.ReadKey();
        }
    }
}
