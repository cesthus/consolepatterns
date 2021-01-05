using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorator
{
    public class Navigation : CarDecorator
    {
        public Navigation(Car car) : base(car)
        {
            Description = "Navigation";
        }

        public override double GetCarPrice()
        {
            return base.GetCarPrice() + 3000;
        }

        public override string GetDescription()
        {
            return $"{_car.GetDescription()}, {Description}";
        }
    }
}
