using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// Builder abstract class
    /// </summary>
    public abstract class CarBuilder
    {
        protected readonly Car _car = new Car();
        public abstract void SetHorsePower();
        public abstract void SetTopSpeed();
        public abstract void SetImpresiveFeature();

        public virtual Car GetCar()
        {
            return _car;
        }
    }
}
