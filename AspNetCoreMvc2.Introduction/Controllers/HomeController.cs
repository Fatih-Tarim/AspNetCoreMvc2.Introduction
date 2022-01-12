using AspNetCoreMvc2.Introduction.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvc2.Introduction.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from first application";
        }

        public ViewResult Index2()
        {
            return View();
        }

        public ViewResult Index3()
        {
            List<Employee> employee = new List<Employee> 
            { 
                new Employee{Id=1,FirstName="Fatih",LastName="Tarım",CityId=1},
                new Employee{Id=2,FirstName="Burak",LastName="Tarım",CityId=2},
                new Employee{Id=3,FirstName="Çağatay",LastName="Çınar",CityId=3}
            };

            List<string> cities = new List<string> {"Ankara","İstanbul"};

            var model = new employeeViewListModel
            {
                Employees = employee,
                Cities = cities
            };

            return View(model);
        }

        public StatusCodeResult Index4()
        {
            return Ok();
        }
        public IActionResult Index5()
        {
            return BadRequest();
        }

        public RedirectResult Index6()
        {
            return Redirect("/Home/Index3");
        }
        public IActionResult Index7()
        {
            return RedirectToAction("/Home/Index2");
        }
        public IActionResult Index8()
        {
            return RedirectToRoute("default");
        }

        public JsonResult Index9()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirstName="Fatih",LastName="Tarım",CityId=1},
                new Employee{Id=2,FirstName="Burak",LastName="Tarım",CityId=2},
                new Employee{Id=3,FirstName="Çağatay",LastName="Çınar",CityId=3}
            };
            return Json(employees);
        }

        public IActionResult RazorDemo()
        {
            List<Employee> employee = new List<Employee>
            {
                new Employee{Id=1,FirstName="Fatih",LastName="Tarım",CityId=1},
                new Employee{Id=2,FirstName="Burak",LastName="Tarım",CityId=2},
                new Employee{Id=3,FirstName="Çağatay",LastName="Çınar",CityId=3}
            };
            List<string> cities = new List<string> { "Ankara", "İstanbul" };
            var model = new employeeViewListModel
            {
                Employees = employee,
                Cities = cities
            };
            return View(model);
        }
    }
}
