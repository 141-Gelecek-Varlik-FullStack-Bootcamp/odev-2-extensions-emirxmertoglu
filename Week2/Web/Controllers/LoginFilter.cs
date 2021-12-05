using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;
using Microsoft.AspNetCore.Routing;

namespace Web.Controllers
{
    public class LoginFilter : Attribute, IActionFilter
    {
        // creating some dummy user data
        public static List<User> users = new List<User>
        {
            new User
            {
                Email = "emir.mertoglu.97@gmail.com",
                FullName = "Emir Mertoglu",
                Id = 1,
                Password = "emir123",
                Role = "Admin"
            },
            new User
            {
                Email = "test@gmail.com",
                FullName = "Test User",
                Id = 2,
                Password = "test00",
                Role = "Manager"
            },
            new User
            {
                Email = "test2@gmail.com",
                FullName = "Test User2",
                Id = 3,
                Password = "test11",
                Role = "Tester"
            }
        };

        private string _role;
        public LoginFilter(string role)
        {
            _role = role;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {}

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // checking any user has the role
            if(users.Any(x => x.Role == _role))
            {
                return;
            }
            else
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Home" }, { "action", "Error" } });
            }
        }
    }
}
