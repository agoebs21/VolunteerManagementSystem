using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VolunteerManagementSystem.Models;
namespace VolunteerManagementSystem.Controllers 
{
    public class VolunteerController : Controller 
    {
        private IVolunteerRepository repository; 
        public VolunteerController(IVolunteerRepository repo)
        {
            repository = repo; 
        }
        public ViewResult ManageVolunteer()
        {
            return View(repository.Volunteers);
        }
        public ViewResult ViewOpportunities()
        {
            return View();
        }
    }
}