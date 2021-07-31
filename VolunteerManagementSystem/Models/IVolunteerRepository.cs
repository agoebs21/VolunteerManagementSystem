using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VolunteerManagementSystem.Models
{
    public interface IVolunteerRepository 
    {
        IEnumerable<Volunteer> Volunteers { get; } 
        IEnumerable<Opportunity> Opportunities { get; }
    }
}