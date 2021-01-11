using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInterpreter.Expression
{
    /// <summary>
    /// Abstract Expression class
    /// </summary>
    public abstract class Expression
    {
        public void Interpret(Context context)
        {
            if (context.Input.Length == 0) return;
            if (context.Input.StartsWith(Nine()))
            {
                context.OutPut += (9 * Multiplier());
                context.Input = context.Input.Substring(2);
            }else if (context.Input.StartsWith(Four()))
            {
                context.OutPut += (4 * Multiplier());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Five()))
            {
                context.OutPut += (5 * Multiplier());
                context.Input = context.Input.Substring(1);
            }
            
            while(context.Input.StartsWith(One()))
            {
                context.OutPut += (1 * Multiplier());
                context.Input = context.Input.Substring(1);
            }
        }

        internal abstract string One();
        internal abstract string Five();
        internal abstract string Four();
        internal abstract string Nine();
        internal abstract int Multiplier();
    }
}
