using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerManagementSystem.Models
{
    public class LoginRepository
    {
        private static List<Login> responses = new List<Login>();
        public static IEnumerable<Login> Responses
        {
            get { return responses; }
        }
        public static void AddResponse(Login response)
        {
            responses.Add(response);
        }
    }
}
