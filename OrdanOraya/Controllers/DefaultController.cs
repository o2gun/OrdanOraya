using Microsoft.AspNetCore.Mvc;

namespace OrdanOrayaProje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
