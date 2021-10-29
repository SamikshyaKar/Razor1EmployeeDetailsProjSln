using System;
using System.Collections.Generic;
using System.Text;

namespace Razor1EmployeeDetailsProj.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Email  { get; set; }

        public string photopath { get; set; }

        public Department? Department { get; set; }
    }
}
