using Microsoft.AspNetCore.Identity;

namespace DemoUserAuth.Models
{
    public class Users : IdentityUser
    {
        public required string FullName { get; set; }
    }
}
