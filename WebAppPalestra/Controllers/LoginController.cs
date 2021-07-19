using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPalestra.Models;

namespace WebAppPalestra.Controllers
{
    public class LoginController : Controller
    {

        private string user = "pippo";
        private string psw = "pippo";

        public IActionResult Login()
        { 

            return View();
        }

        [HttpPost]
        public IActionResult VerifyLogin(LoginModel login)
        {



            if (login.Password == psw && login.User == user)
            {

                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddMinutes(1);
                HttpContext.Response.Cookies.Append("psw", login.Password, cookieOptions);
                HttpContext.Response.Cookies.Append("Usr", login.User, cookieOptions);

                return RedirectToAction("index","Home"); 

            }
            else {

                return View("Login");

            }


            
        }
    }
}
