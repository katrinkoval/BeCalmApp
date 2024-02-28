using BeCalm.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeCalm.Infrastructure.Data.EntityTypeConfiguration
{
    internal class SpecialityEntityConfiguration : IEntityTypeConfiguration<Speciality>
    {
        public void Configure(EntityTypeBuilder<Speciality> builder)
        {
            builder.Property(s => s.Id).IsRequired();

            builder.Property(s => s.Name)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
