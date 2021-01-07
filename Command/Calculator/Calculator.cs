using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Calculator
{
    /// <summary>
    /// Receiver class
    /// </summary>
    public class Calculator
    {
        private int _cur = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': _cur += operand; break;
                case '-': _cur -= operand; break;
                case '*': _cur *= operand; break;
                case '/': _cur /= operand; break;
            }

            Console.WriteLine("Current value = {0,3} (following {1} {2})", _cur, @operator, operand);
        }
    }
}
