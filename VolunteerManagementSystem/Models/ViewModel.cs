using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerManagementSystem.Models
{
    public class ViewModel
    {
        public IEnumerable<Volunteer> Volunteers { get; set; }
        public IEnumerable<Opportunity> Opportunities { get; set; }
    }
}
