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
        
        public ViewResult ManageVolunteer(Login login)
        {
            return View(new ViewModel
            {
                CurrentUser = login.Username,
                Volunteers = repository.Volunteers,
                Opportunities = repository.Opportunities
            });
        }

        public ViewResult EditVolunteer(int volunteerId) =>
         View(repository.Volunteers
         .FirstOrDefault(v => v.VolunteerID == volunteerId));

        [HttpPost]
        public IActionResult EditVolunteer(Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                repository.SaveVolunteer(volunteer);
                TempData["message"] = $"{volunteer.FirstName + ' ' + volunteer.LastName} has been saved";
                return RedirectToAction("ManageVolunteer");
            }
            else
            {
                // there is something wrong with the data values
                return View(volunteer);
            }
        }
        public ViewResult CreateVolunteer() => View("EditVolunteer", new Volunteer());
        public ViewResult ViewOpportunities()
        {
            return View(repository.Opportunities);
        }

        public ViewResult ManageOpportunity(Login login)
        {
            return View(new ViewModel
            {
                CurrentUser = login.Username,
                Volunteers = repository.Volunteers,
                Opportunities = repository.Opportunities
            });
        }

        public ViewResult EditOpportunity(int opportunityId) =>
        View(repository.Opportunities
        .FirstOrDefault(o => o.OpportunityID == opportunityId));

        [HttpPost]
        public IActionResult EditOpportunity(Opportunity opportunity)
        {
            if (ModelState.IsValid)
            {
                repository.SaveOpportunity(opportunity);
                TempData["message"] = $"{opportunity.Title} has been saved";
                return RedirectToAction("ManageOpportunity");
            }
            else
            {
                // there is something wrong with the data values
                return View(opportunity);
            }
        }
        public ViewResult CreateOpportunity() => View("EditOpportunity", new Opportunity());
        [HttpPost]
        public IActionResult Delete(int opportunityId)
        {
            Opportunity deletedOpportunity = repository.DeleteOpportunity(opportunityId);
            if (deletedOpportunity != null)
            {
                TempData["message"] = $"{deletedOpportunity.Title} was deleted";
            }
            return RedirectToAction("ManageOpportunity");
        }
        public ViewResult ViewVolunteers()
        {
            return View(new ViewModel
            {
                Volunteers = repository.Volunteers,
                Opportunities = repository.Opportunities
            });
        }

        public ViewResult SearchForm()
        {
            return View();
        }
        public ViewResult FilterForm()
        {
            return View();
        }

        public ViewResult SearchVol(SearchTerm term)
         => View("ManageVolunteer", new ViewModel
         {
             Volunteers = repository.Volunteers
            .Where(p => term.SearchString == null || p.FirstName.Contains(term.SearchString, StringComparison.CurrentCultureIgnoreCase) || p.LastName.Contains(term.SearchString, StringComparison.CurrentCultureIgnoreCase))
             .OrderBy(p => p.LastName)
         });
         
 
        public ViewResult FilterVol(FilterTerm term) => View("ManageVolunteer", new ViewModel
            {
                Volunteers = repository.Volunteers
                .Where(p => term.FilterString == null || term.FilterString.Contains(p.Approval))
                    .OrderBy(p => p.LastName)
             });
           
        public ViewResult SearchOpp(SearchTerm term)
             => View("ManageOpportunity", new ViewModel
             {
                 Opportunities = repository.Opportunities
                .Where(p => term.SearchString == null || p.Title.Contains(term.SearchString, StringComparison.CurrentCultureIgnoreCase))
                 .OrderBy(p => p.Title)
             });


         public ViewResult FilterOpp(FilterTerm term) 
            => View("ManageOpportunity", new ViewModel
            {
                Opportunities = repository.Opportunities
                    .Where(p => term.FilterString == null || term.FilterString.Contains(p.Center))
                        .OrderBy(p => p.Title)
            });

        public ViewResult MatchVol(String center)
           => View("ViewOpportunities", new ViewModel
           {
                FilterString = center,
                Opportunities = repository.Opportunities
                   .Where(o => center == null || center.Equals(o.Center))
                       .OrderBy(o => o.Title)
           });

        public ViewResult MatchOpp(String center)
           => View("ViewVolunteers", new ViewModel
           {
               FilterString = center,
               Volunteers = repository.Volunteers
                   .Where(v => center.Equals(v.CentersPreferred))
                       .OrderBy(v => v.FirstName),
           });


    }

     }
            