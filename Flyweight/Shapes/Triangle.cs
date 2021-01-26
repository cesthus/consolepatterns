using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Shapes
{
    public class Triangle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing triangle");
        }
    }
}
