using Microsoft.AspNetCore.Identity;

namespace Project1.Models.Users
{
    public class SuperAdminUser : IdentityUser, INewUser
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public UsersEnum User { get; set; }
        public string UserName { get; set; }
    }
}