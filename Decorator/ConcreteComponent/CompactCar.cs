using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    public class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Compact car";
        }

        public override double GetCarPrice()
        {
            return 14999.00;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
