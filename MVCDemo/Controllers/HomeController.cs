using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.ViewModel;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var stuInfo = new StudentInfoViewModel()
            {
                Student = new Student { Name = "zhangsan", Age=12, Gender="male"},
                Address = new Address { City = "Perth", Region = "WA"}
            };
            //var student = new Student()
            //{
            //    Name = "张三",
            //    Age = 19,
            //    Gender = "男"
            //};
            //ViewData["Name"] = "学生信息";
            //ViewBag.Farewell = "Goodbye";
            return View(stuInfo);
        }

        public IActionResult Create()
        {
            var student = new Student()
            {
                Name = "张三",
                Age = 19,
                Gender = "男"
            };
            return View("Views/Home/Create.cshtml", student);
        }


    }
}
