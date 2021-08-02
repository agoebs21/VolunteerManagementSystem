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
        public ViewResult Edit(int volunteerId) =>
         View(repository.Volunteers
         .FirstOrDefault(v => v.VolunteerID == volunteerId));

        [HttpPost]
        public IActionResult Edit(Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                repository.SaveVolunteer(volunteer);
                TempData["message"] = $"{volunteer.FirstName +' ' + volunteer.LastName} has been saved";
                return RedirectToAction("ManageVolunteer");
            }
            else
            {
                // there is something wrong with the data values
                return View(volunteer);
            }
        }
        public ViewResult Create() => View("Edit", new Volunteer());
        public ViewResult ViewOpportunities()
        {
            return View(repository.Opportunities);
        }
        public ViewResult ManageOpportunity()
        {
            return View(repository.Opportunities);
        }
        public ViewResult ViewVolunteers()
        {
            return View(new ViewModel
            {
                Volunteers = repository.Volunteers,
                Opportunities = repository.Opportunities
            });
        }
    }
}