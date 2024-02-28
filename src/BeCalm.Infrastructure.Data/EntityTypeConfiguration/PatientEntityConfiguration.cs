using BeCalm.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeCalm.Infrastructure.Data.EntityTypeConfiguration
{
    internal class PatientEntityConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.Property(chm => chm.Id).IsRequired();
            builder.Property(chm => chm.UserId).IsRequired();

            builder.HasOne(p => p.Identity)
                .WithOne()
                .HasForeignKey<Patient>(p => p.UserId)
                .HasPrincipalKey<User>(u => u.Id);

        }
    }
}
