using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// Leaf class - will be leaf node in tree sctructure
    /// Has no children
    /// </summary>
    public class Employee : IEmployee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }

        public void PerformanceSummary()
        {
            Console.WriteLine($"Performance summary of employee: " +
                $"{Name} is {Rating} out of 5");
        }
    }
}
