using Microsoft.AspNetCore.Mvc;

namespace WebAppNetCoreMVC.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
