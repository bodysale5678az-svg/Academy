using Microsoft.AspNetCore.Mvc;

namespace Academy.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
