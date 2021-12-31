using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            IList<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { ID = 414, FirstName = "Bhavya", LastName = "Sree" });
            employees.Add(new Employee() { ID = 415, FirstName = "Kavya", LastName = "Sree" });
            employees.Add(new Employee() { ID = 416, FirstName = "Navya", LastName = "Sree" });

            ViewData["employees"] = employees;

            ViewBag.TotalEmployees = employees.Count();
            ViewBag.CompanyName = "IBM";

            return View();
        }
    }
}





