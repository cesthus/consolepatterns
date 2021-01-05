using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorator
{
    public class SunRoof : CarDecorator
    {
        public SunRoof(Car car) : base(car)
        {
            Description = "Sunroof";
        }

        public override double GetCarPrice()
        {
            return base.GetCarPrice() + 450;
        }

        public override string GetDescription()
        {
            return $"{_car.Description},{Description}";
        }
    }
}
