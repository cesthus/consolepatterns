using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType.ColorPrototype
{
    public class Color : ColorPrototype
    {
        private int _yellow;
        private int _orange;
        private int _red;

        public Color(int yellow, int orange, int red)
        {
            _yellow = yellow;
            _orange = orange;
            _red = red;
        }

        public override ColorPrototype Clone()
        {
            Console.WriteLine("RBG color is cloned to: {0,3}, {1,3}, {2,3}", _yellow, _orange, _red);
            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
