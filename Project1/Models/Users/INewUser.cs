using Microsoft.AspNetCore.Identity;

namespace Project1.Models.Users
{
    public interface INewUser
    {
        string Email { get; set; }
        string Password { get; set; }
        UsersEnum User { get; set; }
        string UserName { get; set; }
    }
}