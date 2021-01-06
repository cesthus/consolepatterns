using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalCarBuilder normalCar = new NormalCarBuilder();
            SuperCarBuilder superCar = new SuperCarBuilder();

            CarFactory carFactory = new CarFactory();
            var builders = new List<CarBuilder> { normalCar, superCar };
            foreach(var item in builders)
            {
                var b = carFactory.Build(item);
                Console.WriteLine($"Car request by {item.GetType().Name}"+
                    $"\n Horse power: {b.HorsePower}" +
                    $"\n Top Speed: {b.TopSpeedMPH}");
            }

            Console.ReadKey();
        }
    }
}
