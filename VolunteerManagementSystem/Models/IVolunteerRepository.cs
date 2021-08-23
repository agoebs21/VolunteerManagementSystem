using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VolunteerManagementSystem.Models
{
    public interface IVolunteerRepository 
    {
        IEnumerable<Login> Login { get; }
        void SaveLogin(Login login);
        IEnumerable<Volunteer> Volunteers { get; }
        void SaveVolunteer(Volunteer volunteer);
        IEnumerable<Opportunity> Opportunities { get; }
        void SaveOpportunity(Opportunity opportunity);
        Opportunity DeleteOpportunity(int opportunityID);
    }
}