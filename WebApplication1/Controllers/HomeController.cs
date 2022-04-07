using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IEnumerable<Employee> Index()
        {
            //return _employeeRepository.GetEmployee(1).Name;
            //return Json(new { id = 1, name = "kasun" });
            return _employeeRepository.GetAllEmployee();
        }

        public ObjectResult Details(int id)
        {
            Employee employee = _employeeRepository.GetEmployee(id);
            return new ObjectResult(employee);
            //return Json(new { id = 1, name = "kasun" });
        }
    }
}
