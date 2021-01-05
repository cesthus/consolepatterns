using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Compact car
            Car compactCar = new CompactCar();
            compactCar = new Navigation(compactCar);
            //compactCar = new SunRoof(compactCar);
            compactCar = new LeatherSeats(compactCar);
            Console.WriteLine($"Description: {compactCar.GetDescription()}");
            Console.WriteLine($"Final Price: {compactCar.GetCarPrice():C2}");

            //Full size car
            Car fullCar = new CompactCar();
            fullCar = new Navigation(fullCar);
            fullCar = new SunRoof(fullCar);
            fullCar = new LeatherSeats(fullCar);
            Console.WriteLine($"Description: {fullCar.GetDescription()}");
            Console.WriteLine($"Final Price: {fullCar.GetCarPrice():C2}");

            Console.ReadKey();
        }
    }
}
