using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practices.Models;

namespace practices.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            IList<Department> dep = new List<Department>();
            dep.Add(new Department() { ID = 123, Name = "Venkat", Salary = "3LPA" });
            dep.Add(new Department() { ID = 124, Name = "Mugesh", Salary = "5LPA" });
            dep.Add(new Department() { ID = 125, Name = "Ajay", Salary = "7LPA" });
            dep.Add(new Department() { ID = 176, Name = "Ramesh", Salary = "5LPA" });
            dep.Add(new Department() { ID = 128, Name = "Siva", Salary = "6LPA" });

            ViewData["Department"] = dep;
            return View();
        }
    }
}
