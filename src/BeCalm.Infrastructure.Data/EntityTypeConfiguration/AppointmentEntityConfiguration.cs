using BeCalm.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeCalm.Infrastructure.Data.EntityTypeConfiguration
{
    internal class AppointmentEntityConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.TherapistId).IsRequired();
            builder.Property(x => x.PatientId).IsRequired();

            builder.HasOne(a => a.TherapistAtAppointment)
                .WithMany(t => t.Appointments)
                .HasForeignKey(a => a.TherapistId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.PatientAtAppointment)
                .WithMany(p => p.Appointments)
                .HasForeignKey(a => a.PatientId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(x => x.PatientId).IsRequired();
            builder.Property(x => x.TherapistId).IsRequired();

            builder.Property(x => x.StartsAt).IsRequired();
            builder.Property(x => x.EndsAt).IsRequired();

            builder.Property(x=> x.Status)
                 .HasConversion<byte>()
                 .IsRequired();

        }
    }
}
