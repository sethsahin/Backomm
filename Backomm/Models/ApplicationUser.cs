using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Backomm.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<IdentityUserClaim<string>> Claims { get; set; }
        public ICollection<IdentityUserLogin<string>> Logins { get; set; }
        public ICollection<IdentityUserToken<string>> Tokens { get; set; }
        public ICollection<IdentityUserRole<string>> UserRoles { get; set; }

        public Group Group { get; set; }

        public Event Event { get; set; }
    }
}