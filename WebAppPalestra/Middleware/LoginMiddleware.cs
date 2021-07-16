using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPalestra.Middleware
{
    public class LoginMiddleware : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {



            if (context.Request.Cookies["psw"] == null && context.Request.Path != "/Login/Login")
                //if (false==true)
                {
                var appo = context.Request.Cookies["psw"];
                var appo2 = context.Request.Path;
                context.Response.Redirect("https://localhost:44317/Login/Login");
                var appo3 = context.Request.Path;
            }


            var appo1 = context.Request.Cookies["psw"];


            return next.Invoke(context);
        }
    }
}
