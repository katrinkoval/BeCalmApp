using BeCalm.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeCalm.Infrastructure.Data.EntityTypeConfiguration
{
    internal class TherapistEntityConfiguration : IEntityTypeConfiguration<Therapist>
    {
        public void Configure(EntityTypeBuilder<Therapist> builder)
        {
            builder.Property(t => t.Id).IsRequired();
            builder.Property(t => t.UserId).IsRequired();
            builder.Property(t => t.Price)
                .HasColumnType("money")
                .IsRequired();

            builder.HasOne(t => t.Identity)
               .WithOne()
               .HasForeignKey<Therapist>(t => t.UserId)
               .HasPrincipalKey<User>(t => t.Id);

            builder.HasMany(t => t.Specialities)
                .WithMany(s => s.Therapists)
                .UsingEntity("TherapistSpeciality");

        }
    }
}
