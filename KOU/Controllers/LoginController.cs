using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using KOU.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace KOU.Controllers
{
    public class LoginController : Controller
    {
        AContext c = new AContext();

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Admin p)
        {
            var datavalue = c.Admins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, p.UserName)
                };
                var userIdentity= new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlış");
            return Index();
        }
    }
}