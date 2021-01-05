using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorator
{
    public class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car): base(car)
        {
            Description = "Leather Seats";
        }

        public override double GetCarPrice()
        {
            return _car.GetCarPrice() + 2500;
        }

        public override string GetDescription()
        {
            return $"{_car.GetDescription()}, {Description}";
        }
    }
}
