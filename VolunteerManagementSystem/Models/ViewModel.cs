using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VolunteerManagementSystem.Models
{
    public class ViewModel
    {
        public IEnumerable<Volunteer> Volunteers { get; set; }
        public IEnumerable<Opportunity> Opportunities { get; set; }
        public string SearchString { get; set; }
        public string FilterString { get; set; }
        public IEnumerable<Login> Login { get; set; }
        public string CurrentUser { get; set; }
    }
}
