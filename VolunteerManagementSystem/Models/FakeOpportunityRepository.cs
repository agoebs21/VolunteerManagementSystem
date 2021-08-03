using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VolunteerManagementSystem.Models
{
 public class FakeVolunteertRepository : IVolunteerRepository
 {
 public IEnumerable<Opportunity> Opportunities => new List<Opportunity>{new Opportunity { OpportunityID =  1, Title =  "Science Fair", Description =  "A person critiques the projects in the science fair.  He/she also promotes good science education by teaching the parents about the scientific method." },
new Opportunity { OpportunityID =  2, Title =  "Health Clinic", Description =  "The volunteer assess the health of any patients that come into the clinic." },
new Opportunity { OpportunityID =  3, Title =  "Computer Education", Description =  "A person teaches the young students how to use a computer." },
new Opportunity { OpportunityID =  4, Title =  "Product Management", Description =  "The volunteer evaluates the status of ingoing/outgoing deliveries." }
};
 }
}
