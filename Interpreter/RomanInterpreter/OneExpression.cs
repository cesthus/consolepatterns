using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInterpreter.Expression
{
    public class OneExpression : Expression
    {
        internal override string Five()
        {
            return "V";
        }

        internal override string Four()
        {
            return "IV";
        }

        internal override int Multiplier()
        {
            return 1;
        }

        internal override string Nine()
        {
            return "IX";
        }

        internal override string One()
        {
            return "I";
        }
    }
}
