using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor1EmployeeDetailsProj.Models;
using Razor1EmployeeDetailsProj.Services;

namespace Razor1EmployeeDetailsProj.Pages.Employees
{
    public class EmpDetailsModel : PageModel
    {
        private readonly IEmployeesRepositories employeesRepositories;

        public EmpDetailsModel(IEmployeesRepositories employeesRepositories)
        {
            this.employeesRepositories = employeesRepositories;
        }

        public Employee EmpDetailProperty { get; private set; }

        public void OnGet(int id)
        {
           EmpDetailProperty= employeesRepositories.GetEmployee(id);
        }
    }
}
