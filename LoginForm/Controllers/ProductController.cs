using Microsoft.AspNetCore.Mvc;

namespace LoginForm.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
