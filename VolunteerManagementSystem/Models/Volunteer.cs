using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VolunteerManagementSystem.Models
{
    public class Volunteer
    {
        public int VolunteerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Username { get; set; }
        public char Password { get; set; } 
        public char CentersPreferred { get; set; } //address
        public string SkillsInterests { get; set; } 
        public string Availability { get; set; } 
        public char Address { get; set; }
        public int PhoneNumber { get; set; }
        public char Email { get; set; }
        public string Education { get; set; }
        public string Licenses { get; set; }
        public string EmergencyName { get; set; }
        public int EmergencyPhone { get; set; }
        public char EmergencyEmail { get; set; }
        public char EmergencyAddress { get; set; }
        public bool ValidLicense { get; set; }
        public bool ValidSocial { get; set; }
        public string Approval { get; set; }
    }

}
