using BeCalm.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BeCalm.Infrastructure.Data.EntityTypeConfiguration
{
    internal class ChatEntityConfiguration: IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.Property(ch => ch.Id).IsRequired();
            builder.Property(ch => ch.TherapistId).IsRequired();
            builder.Property(ch => ch.PatientId).IsRequired(); 

            //builder.HasKey(ch => new {ch.PatientId, ch.TherapistId});

            builder.HasMany(ch => ch.Messages)
              .WithOne()
              .HasForeignKey(ch => ch.ChatId)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ch => ch.Patient)
                .WithMany(p => p.Chats)
                .HasForeignKey(ch => ch.PatientId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ch => ch.Therapist)
                .WithMany(t => t.Chats)
                .HasForeignKey(ch => ch.TherapistId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
    
}
