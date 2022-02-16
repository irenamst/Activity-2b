using Activity_2b.Models;
using Activity_2b.Services;
using Microsoft.AspNetCore.Mvc;

namespace Activity_2b.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            

            return View();
        }
        public IActionResult ProccessLogin(UserModel userModel)
        {
            SecurityServices securityServices = new SecurityServices();

            if(securityServices.IsValid(userModel))
            {
                return View("LoginSuccess", userModel);
            }
            else
            {
                return View("LoginFailure", userModel);
            }
        }
    }
}
