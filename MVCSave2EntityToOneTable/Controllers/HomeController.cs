using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSave2EntityToOneTable.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveSingleData()
        {

            using (var ctx = new TestEFContext())
            {
                Employee emp = new Employee() { Name = "New employee1", Salary=2000 };

                ctx.Employees.Add(emp);
                ctx.SaveChanges();
            }

            ViewBag.Message = "Single employee data added.";
            return View("Index");
        }

        public ActionResult SaveMultipleData()
        {

            List<Employee> oEmp = new List<Employee>
            {
                new Employee{Name="New employee2", Salary=5000},
                new Employee{Name="New employee3", Salary=6000},
                new Employee{Name="New employee4", Salary=7000}
            };

            using (var ctx = new TestEFContext())
            {
                foreach (Employee emp in oEmp)
                {
                    ctx.Employees.Add(emp);
                }
                ctx.SaveChanges();
            }

            ViewBag.Message = "Multiple employee data added.";

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}