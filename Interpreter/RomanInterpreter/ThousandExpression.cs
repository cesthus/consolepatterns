using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInterpreter.Expression
{
    /// <summary>
    /// A terminal expression class
    /// <remarks>
    /// Thousand checks the Roman Numeral M
    /// </remarks>
    /// </summary>
    public class ThousandExpression : Expression
    {
        internal override string Five()
        {
            return " ";
        }

        internal override string Four()
        {
            return " ";
        }

        internal override int Multiplier()
        {
            return 1000;
        }

        internal override string Nine()
        {
            return " ";
        }

        internal override string One()
        {
            return "M";
        }
    }
}
