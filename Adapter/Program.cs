using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Employee List");

            ITarget adapter = new EmployeeAdapter();
            foreach(string employee in adapter.GetEmployees())
            {
                Console.WriteLine(employee);
            }

            Console.ReadKey();
        }
    }
}
