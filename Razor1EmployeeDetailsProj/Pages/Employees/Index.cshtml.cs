using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor1EmployeeDetailsProj.Services;
using Razor1EmployeeDetailsProj.Models;

namespace Razor1EmployeeDetailsProj.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeesRepositories employeesRepositories;

        public IndexModel(IEmployeesRepositories employeesRepositories)
        {
            this.employeesRepositories = employeesRepositories;
        }

        public IEnumerable<Employee> Employeesproperty { get; set; }
        public void OnGet()
        {
            Employeesproperty = employeesRepositories.GetAllEmployeeDetails();
        }
    }
}
