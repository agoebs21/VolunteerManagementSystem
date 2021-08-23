using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VolunteerManagementSystem.Models;

namespace VolunteerManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private IVolunteerRepository repository;
        public HomeController(IVolunteerRepository repo)
        {
            repository = repo;
        }
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public ViewResult AdminLogin()
        {
            return View();
        }
        
        public ViewResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AdminLogin(Login login)
        {
            foreach (var l in repository.Login)
            {
                if (login.Username == null || login.Password == null)
                {
                    return View();
                }
                else if (login.Username.Equals(l.Username) && login.Password.Equals(l.Password))
                {
                    
                    return View("AdminHome", new ViewModel { CurrentUser = login.Username });
                }
                else 
                {
                    continue;
                }
            }
            //validation
            ViewBag.ErrorMsg = "Invalid Username or Password";
            return View();
        }
        public ViewResult AdminHome(Login login)
        {
            return View(new ViewModel { Login = repository.Login, CurrentUser = login.Username });
        }
    }
}
