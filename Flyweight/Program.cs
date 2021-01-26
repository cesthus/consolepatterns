using Flyweight.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeObjectFactory sof = new ShapeObjectFactory();
            IShape shape = sof.GetShape("Triangle");
            shape.Print();
            shape = sof.GetShape("Triangle");
            shape.Print();
            shape = sof.GetShape("Triangle");
            shape.Print();

            int total = sof.TotalObjectsCreated;
            Console.WriteLine("Number of objects created: "+total);
            Console.ReadKey();
        }
    }
}
