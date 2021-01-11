using RomanInterpreter.Expression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Expression roman
            string roman = "MMXVII";
            Context context = new Context(roman);

            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            foreach (var exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine($"{roman} = {context.OutPut}");

            Console.ReadKey();
        }
    }
}
