using System.ComponentModel.DataAnnotations;

namespace VolunteerManagementSystem.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Please enter username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter password")] 
        public string Password {get; set; }
    }
}
/*hi*/
/* hello world */
