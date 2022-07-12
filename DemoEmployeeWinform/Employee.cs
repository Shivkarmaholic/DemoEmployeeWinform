using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEmployeeWinform
{
    [Serializable]
    public class Employee
    {
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public int Emp_salary { get; set; }

    }
}
