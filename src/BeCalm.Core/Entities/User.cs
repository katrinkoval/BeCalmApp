using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BeCalm.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Role {  get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsVarified { get; set; }
    }
}
