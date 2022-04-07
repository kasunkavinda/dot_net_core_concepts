using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [Route("")]
        [Route("/")]
        [Route("[action]")]
        public IEnumerable<Employee> Index()
        {
            //return _employeeRepository.GetEmployee(1).Name;
            //return Json(new { id = 1, name = "kasun" });
            return _employeeRepository.GetAllEmployee();
        }

        [Route("[action]/{id?}")]
        public ObjectResult Details(int? id)
        {
            Employee employee = _employeeRepository.GetEmployee(id??1);
            return new ObjectResult(employee);
            //return Json(new { id = 1, name = "kasun" });
        }

        public ViewResult Create()
        {
            return View();
        }
    }
}
