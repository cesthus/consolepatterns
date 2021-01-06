using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ricky = new Employee { EmployeeID = 1, Name = "Ricky", Rating = 3 };
            Employee mike = new Employee { EmployeeID = 2, Name = "Mike", Rating = 4 };
            Employee oliver = new Employee { EmployeeID = 3, Name = "Oliver", Rating = 2 };

            Supervisor ronny = new Supervisor { EmployeeID = 10, Name = "Ronny", Rating = 5};
            Supervisor bobby = new Supervisor { EmployeeID = 11, Name = "Bobby", Rating = 4};

            ronny.AddSubordinate(ricky);
            ronny.AddSubordinate(mike);

            bobby.AddSubordinate(oliver);

            Console.WriteLine("Employee can see their performance");
            ricky.PerformanceSummary();

            Console.WriteLine("\n \n Supervisor can also see their subordinates performance summary");
            ronny.PerformanceSummary();

            Console.WriteLine("\n \nSubordinate Performance Record:");
            foreach(Employee employee in ronny.listSubordinates)
            {
                employee.PerformanceSummary();
            }

            Console.ReadKey();
        }
    }
}
