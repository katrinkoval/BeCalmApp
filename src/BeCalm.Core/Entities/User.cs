

namespace BeCalm.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public UserRole Role {  get; set; }
        public string PhotoUrl { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }

    }
}
