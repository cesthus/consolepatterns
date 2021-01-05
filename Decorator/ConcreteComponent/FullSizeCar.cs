using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    public class FullSizeCar : Car
    {
        public FullSizeCar()
        {
            Description = "Full size car";
        }
        public override double GetCarPrice()
        {
            return 340000.00;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
