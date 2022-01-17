using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewData.Models;

namespace ViewData.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            IList<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id = 123, FirstName = "Venkat", LastName = "Deepak" });
            employees.Add(new Employee() { Id = 1234, FirstName = "Raj", LastName = "Kumar" });
            employees.Add(new Employee() { Id = 123, FirstName = "Siva", LastName = "Kumar" });

            ViewData["Employee"] = employees;
            return View();
        }
    }
}
