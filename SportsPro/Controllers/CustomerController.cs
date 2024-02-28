using Microsoft.AspNetCore.Mvc;

namespace SportsPro.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
