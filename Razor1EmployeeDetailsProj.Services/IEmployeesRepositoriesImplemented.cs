using Razor1EmployeeDetailsProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Razor1EmployeeDetailsProj.Services
{
   public  class IEmployeesRepositoriesImplemented : IEmployeesRepositories
    {
        private readonly List<Employee> _employeelist;
        public IEmployeesRepositoriesImplemented()
        {

            _employeelist = new List<Employee>()
            {

        new Employee(){EmpID=1,Name="samu",Email="Samu@gmail.com",Department=Department.HR,photopath="DSC_0097.jpg" },


        new Employee(){EmpID=2,Name="Amu",Email="Amu@gmail.com",Department=Department.HR },
        new Employee(){EmpID=3,Name="Dhamu",Email="Dhamu@gmail.com",Department=Department.HR },
        new Employee(){EmpID=4,Name="Ramu",Email="Ramu@gmail.com",Department=Department.HR }
            };
        
        }
        public IEnumerable<Employee> GetAllEmployeeDetails()
        {
            return _employeelist;
        }

        public Employee GetEmployee(int id)
        {
            return _employeelist.FirstOrDefault(e => e.EmpID == id);
        }
    }
}
