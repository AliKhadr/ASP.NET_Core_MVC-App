using Microsoft.AspNetCore.Mvc;

namespace MvcProjectAspNet.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
