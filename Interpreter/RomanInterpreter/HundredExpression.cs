using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInterpreter.Expression
{
    public class HundredExpression : Expression
    {
        internal override string Five()
        {
            return "D";
        }

        internal override string Four()
        {
            return "CD";
        }

        internal override int Multiplier()
        {
            return 100;
        }

        internal override string Nine()
        {
            return "CM";
        }

        internal override string One()
        {
            return "C";
        }
    }
}
