using Microsoft.AspNetCore.Mvc;

namespace AlteCashIdentityProject.Presentation.Layer.Controllers
{
    public class MyProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
