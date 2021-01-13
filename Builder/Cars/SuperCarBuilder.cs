using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SuperCarBuilder : CarBuilder
    {
        public override void SetHorsePower()
        {
            _car.HorsePower = 1650;
        }

        public override void SetImpresiveFeature()
        {
            _car.MostImpresiveFeature = "Can fly";
        }

        public override void SetTopSpeed()
        {
            _car.TopSpeedMPH = 600;
        }
    }
}
