using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DepartmentsController : Controller
    {
        public string List()
        {
            return "List() of departments controller";
        }
        public string Details()
        {
            return "Details() of departments controller";
        }
    }
}
