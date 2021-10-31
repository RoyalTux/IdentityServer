using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Infrastructure.Data.Identity
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }        
    }
}
