using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankDetails.Models;

namespace BankDetails.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            IList<Account> Acc = new List<Account>();
            Acc.Add(new Account() { A_Id = 123, A_Name = "Venkat", A_Address = "abc" });
            Acc.Add(new Account() { A_Id = 122, A_Name = "Deepak", A_Address = "XYZ" });
            Acc.Add(new Account() { A_Id = 124, A_Name = "Mugesh", A_Address = "PQR" });
            Acc.Add(new Account() { A_Id = 125, A_Name = "Prabha", A_Address = "LMN" });
            Acc.Add(new Account() { A_Id = 127, A_Name = "Vishwa", A_Address = "FGH" });

            ViewData["Account"] = Acc;
            ViewBag.Total = Acc.Count();
            return View();
        }
    }
}
