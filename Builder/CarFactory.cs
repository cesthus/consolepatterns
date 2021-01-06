using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// Director class
    /// </summary>
    public class CarFactory
    {
        public Car Build(CarBuilder builder)
        {
            builder.SetHorsePower();
            builder.SetTopSpeed();
            builder.SetImpresiveFeature();
            return builder.GetCar();
        }
    }
}
