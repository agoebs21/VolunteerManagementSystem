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
            if (ModelState.IsValid)
            {
                LoginRepository.AddResponse(login);
                return View("AdminHome", login);
            }
            else
            {
                // there is a validation error 
                return View();
            }
        }
        public ViewResult ManageOpportunity()
        {
            // need to make database to store opportunities
            return View(LoginRepository.Responses.Where(r => r.Username == "Ashley"));
        }

        
    }
}
