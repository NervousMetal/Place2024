using Microsoft.AspNetCore.Identity;

namespace place2024.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
