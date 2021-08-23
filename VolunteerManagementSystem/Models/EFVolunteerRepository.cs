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
        public IEnumerable<Login> Login => context.Login;
        public void SaveLogin(Login login)
        {
            if (login.ID == 0)
            {
                context.Login.Add(login);
            }
            else
            {
                Login dbEntry = context.Login
                .FirstOrDefault(l => l.ID == login.ID);
                if (dbEntry != null)
                {
                    dbEntry.Username = login.Username;
                    dbEntry.Password = login.Password;
                    dbEntry.Designation = login.Designation;
                }
            }
            context.SaveChanges();
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
        public void SaveOpportunity(Opportunity opportunity)
        {
            if (opportunity.OpportunityID == 0)
            {
                context.Opportunities.Add(opportunity);
            }
            else
            {
                Opportunity dbEntry = context.Opportunities
                .FirstOrDefault(o => o.OpportunityID == opportunity.OpportunityID);
                if (dbEntry != null)
                {
                    dbEntry.Title = opportunity.Title;
                    dbEntry.Description = opportunity.Description;
                    dbEntry.Center = opportunity.Center;
                }
            }
            context.SaveChanges();
        }
        public Opportunity DeleteOpportunity(int opportunityID)
        {
            Opportunity dbEntry = context.Opportunities
            .FirstOrDefault(o => o.OpportunityID == opportunityID);
            if (dbEntry != null)
            {
                context.Opportunities.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}