using System;
using System.Collections.Generic;
using Razor1EmployeeDetailsProj.Models;

namespace Razor1EmployeeDetailsProj.Services
{
    public interface IEmployeesRepositories
    {
        IEnumerable<Employee> GetAllEmployeeDetails();

         Employee GetEmployee(int id);
    }
}
