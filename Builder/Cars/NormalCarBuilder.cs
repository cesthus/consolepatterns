using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// Concrete Builder class
    /// </summary>
    public class NormalCarBuilder : CarBuilder
    {
        public override void SetHorsePower()
        {
            _car.HorsePower = 120;
        }

        public override void SetImpresiveFeature()
        {
            _car.MostImpresiveFeature = "Has Air conditioning";
        }

        public override void SetTopSpeed()
        {
            _car.TopSpeedMPH = 70;
        }
    }
}
