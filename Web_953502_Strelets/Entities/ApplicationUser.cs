using Microsoft.AspNetCore.Identity;

namespace Web_953502_Strelets.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public byte[] AvatarImage { get; set; }
    }
}
