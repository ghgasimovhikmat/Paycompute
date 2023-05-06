using Microsoft.AspNetCore.Mvc;
using Paycompute.Models;
using Paycompute.Services;

namespace Paycompute.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
           _employeeService = employeeService;
        }
        public IActionResult Index()
        {
            var employees = _employeeService.GetALL().Select(employee => new EmployeeIndexViewModel
            {
                Id=employee.Id,
                EmployeeNo= employee.EmployeeNo,
                FullName=employee.FullName,
                Gender=employee.Gender,
                ImageUrl=employee.ImageUrl,
                DateJoined=employee.DateJoined,
                Desigination=employee.Designation,
                City=employee.City

            }).ToList();
            return View(employees);
        }
    }
}
