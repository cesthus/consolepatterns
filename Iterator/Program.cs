using Iterator.Aggregate;
using Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            INewsPaper newyork = new NYPaper();
            INewsPaper lat = new LAPaper();

            IIterator nypIterator = newyork.CreateIterator();
            IIterator lapIterator = lat.CreateIterator();

            Console.WriteLine("---------- NY Paper");
            PrintReporters(nypIterator);
            
            Console.WriteLine("---------- LA Paper");
            PrintReporters(lapIterator);
            Console.ReadKey();
        }

        private static void PrintReporters(IIterator iterator)
        {
            iterator.First();
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
