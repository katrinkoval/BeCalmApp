using Microsoft.EntityFrameworkCore;
using BeCalm.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace BeCalm.Infrastructure.Data
{
    public class BeCalmDbContext: IdentityDbContext
    {
        public BeCalmDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Therapist> Therapists { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<TherapistPatient> TherapistPatients { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BeCalmDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

    }
}
