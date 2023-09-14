using AlteCashIdentityProject.EntityLayer.Concrete;
using AlteCashIdentityProject.Presentation.Layer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AlteCashIdentityProject.Presentation.Layer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel loginViewModel)
        {
            var result = await _signInManager.PasswordSignInAsync(loginViewModel.Username, loginViewModel.Password, loginViewModel.RememberMe, true);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(loginViewModel.Username);
                if(user.EmailConfirmed==true)
                {
                    return RedirectToAction("Index", "MyProfile");
                }
                else
                {
                    ModelState.AddModelError("","Hesap onaylı değil!");
                }


            }
            else
            {
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı!");
            }

            return View();
        }
    }
}
