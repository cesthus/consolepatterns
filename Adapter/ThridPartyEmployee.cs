using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ThridPartyEmployee
    {
        public List<string> GetEmployeeList()
        {
            List<string> EmployeeList = new List<string>();
            EmployeeList.Add("Hanna");
            EmployeeList.Add("Ross");
            EmployeeList.Add("Peter");
            EmployeeList.Add("Paul");
            return EmployeeList;
        }
    }
}
