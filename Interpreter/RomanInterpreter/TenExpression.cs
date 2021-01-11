using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInterpreter.Expression
{
    public class TenExpression : Expression
    {
        internal override string Five()
        {
            return "L";
        }

        internal override string Four()
        {
            return "XL";
        }

        internal override int Multiplier()
        {
            return 10;
        }

        internal override string Nine()
        {
            return "XC";
        }

        internal override string One()
        {
            return "X";
        }
    }
}
