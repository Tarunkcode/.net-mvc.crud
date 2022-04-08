using Excellent.Traning.Service;
using System.Web.Mvc;

namespace Excellent.Traning.Web.Controllers
{
    public class EmployeeController : Controller
    {
        EXCEntities _db = new EXCEntities();
        // GET: Employee
        public ActionResult GetAllEmpDetail()
        {
            var employeeList = new ExcellentServices(_db).GetEmployees();


            return View(employeeList);
        }
        public ActionResult GetEmpDetail(string id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult SaveEmployee()
        {
            var employee = new Employee();
            return View(employee);
        }
        [HttpPost]
        public ActionResult SaveEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var result = new ExcellentServices(_db).SaveEmployee(employee);
                ViewBag.Status = "Data Insert Sucessfully.";
                return RedirectToAction("GetAllEmpDetail");

            }
            
            return View(employee);
        }
    }
}