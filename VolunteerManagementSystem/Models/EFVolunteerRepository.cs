using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VolunteerManagementSystem.Models 
{
    public class EFVolunteerRepository : IVolunteerRepository
    {
        private ApplicationDbContext context;
        public EFVolunteerRepository(ApplicationDbContext ctx) 
        {
            context = ctx;
        }
        public IEnumerable<Volunteer> Volunteers => context.Volunteers;
        public void SaveVolunteer(Volunteer volunteer)
        {
            if (volunteer.VolunteerID == 0)
            {
                context.Volunteers.Add(volunteer);
            }
            else
            {
                Volunteer dbEntry = context.Volunteers
                .FirstOrDefault(v => v.VolunteerID == volunteer.VolunteerID);
                if (dbEntry != null)
                {
                    dbEntry.FirstName = volunteer.FirstName;
                    dbEntry.LastName = volunteer.LastName;
                    dbEntry.Username = volunteer.Username;
                    dbEntry.Password = volunteer.Password;
                    dbEntry.CentersPreferred = volunteer.CentersPreferred;
                    dbEntry.SkillsInterests = volunteer.SkillsInterests;
                    dbEntry.Availability = volunteer.Availability;
                    dbEntry.Address = volunteer.Address;
                    dbEntry.PhoneNumber = volunteer.PhoneNumber;
                    dbEntry.Email = volunteer.Email;
                    dbEntry.Education = volunteer.Education;
                    dbEntry.Licenses = volunteer.Licenses;
                    dbEntry.EmergencyName = volunteer.EmergencyName;
                    dbEntry.EmergencyPhone = volunteer.EmergencyPhone;
                    dbEntry.EmergencyEmail = volunteer.EmergencyEmail;
                    dbEntry.EmergencyAddress = volunteer.EmergencyAddress;
                    dbEntry.ValidLicense = volunteer.ValidLicense;
                    dbEntry.ValidSocial = volunteer.ValidSocial;
                    dbEntry.Approval = volunteer.Approval;
                }
            }
            context.SaveChanges();
        }
        public IEnumerable<Opportunity> Opportunities => context.Opportunities;
    }
}