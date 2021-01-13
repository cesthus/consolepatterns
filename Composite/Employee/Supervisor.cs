using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// Composite class - will be branch node in tree structure
    /// </summary>
    public class Supervisor : IEmployee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }

        public List<IEmployee> listSubordinates = new List<IEmployee>();

        public void PerformanceSummary()
        {
            Console.WriteLine($"Performance summary of supervisor: "+
                              $"{Name} is {Rating} out of 5");
        }

        public void AddSubordinate(IEmployee employee)
        {
            listSubordinates.Add(employee);
        }

    }
}
