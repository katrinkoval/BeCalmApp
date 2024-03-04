

using Microsoft.AspNetCore.Identity;

namespace BeCalm.Core.Entities
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
