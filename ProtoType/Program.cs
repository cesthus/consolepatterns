using ProtoType.ColorPrototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorController colorController = new ColorController();

            colorController["yellow"] = new Color(255, 255, 0);
            colorController["orange"] = new Color(255, 128, 0);
            colorController["red"] = new Color(128, 255, 0);

            //personalized colos
            colorController["sunny"] = new Color(255, 54, 0);
            colorController["rainy"] = new Color(150, 54, 22);

            Color c1 = colorController["yellow"].Clone() as Color;
            Color c2 = colorController["sunny"].Clone() as Color;
            Color c3 = colorController["rainy"].Clone() as Color;

            Console.ReadKey();
        }
    }
}
