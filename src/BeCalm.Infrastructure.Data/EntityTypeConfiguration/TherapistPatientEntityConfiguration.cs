using BeCalm.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeCalm.Infrastructure.Data.EntityTypeConfiguration
{
    internal class TherapistPatientEntityConfiguration : IEntityTypeConfiguration<TherapistPatient>
    {
        public void Configure(EntityTypeBuilder<TherapistPatient> builder)
        {
            builder.Property(tp => tp.TherapistId).IsRequired();
            builder.Property(tp => tp.PatientId).IsRequired();
            builder.Property(tp => tp.CreatedAt).IsRequired();

            builder.HasKey(tp => new { tp.TherapistId, tp.PatientId });

            builder.HasOne(tp => tp.Patient)
                 .WithMany(p => p.Therapists)
                 .HasForeignKey(tp => tp.PatientId)
                 .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(tp => tp.Therapist)
                 .WithMany(t => t.Patients)
                 .HasForeignKey(tp => tp.TherapistId)
                 .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
