using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    
    public class EmployeeController : Controller
    {
        private readonly IEmpolyeeServices _emp;
        private readonly DbConnect _db;
        public EmployeeController(IEmpolyeeServices emp,DbConnect db)
        {
            _emp = emp;
            _db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string name,string designation,string salary)
        {
            Employee data = new Employee()
            {
                Name=name,
                Designation=designation,
                Salary=long.Parse(salary)
            };
            string msg = "";
            int retval=_emp.InsertNewEmployee(data);
            if(retval==1)
            {
                msg = "Data Inserted Successfully";
            }
            else
            {
                msg = "this user already inserted";
            }
            ViewBag.msg = msg;
            return View();
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(string empcode,string name, string designation, string salary)
        {
            Employee data = new Employee()
            {
                Name = name,
                Designation = designation,
                Salary = long.Parse(salary)
            };
            string msg = "";
            int retval = _emp.updateInfoEmployee(data,int.Parse(empcode));
            if (retval == 1)
            {
                msg = "Data Updated Successfully";
            }
            else
            {
                msg = "this user does not exist";
            }
            ViewBag.msg = msg;
            return View();
        }
    }
}
