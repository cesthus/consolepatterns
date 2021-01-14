using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Visitors
{
    /// <summary>
    /// Concrete visitor class
    /// </summary>
    public class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            employee.VacationDays += 3;
            Console.WriteLine("{0} {1} new vacations days {2}", employee.GetType().Name, employee.Name, employee.VacationDays);
        }
    }
}
