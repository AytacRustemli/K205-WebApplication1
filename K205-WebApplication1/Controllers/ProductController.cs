using Microsoft.AspNetCore.Mvc;

namespace K205_WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
