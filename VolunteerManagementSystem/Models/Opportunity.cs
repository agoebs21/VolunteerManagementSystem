using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerManagementSystem.Models
{
    public class Opportunity
    {
        public int OpportunityID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Center { get; set; }
    }
}
