using BeCalm.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BeCalm.Infrastructure.Data.EntityTypeConfiguration
{
    internal class ChatMessageEntityConfiguration : IEntityTypeConfiguration<ChatMessage>
    {
        public void Configure(EntityTypeBuilder<ChatMessage> builder)
        {
            builder.Property(chm => chm.Id).IsRequired();
            builder.Property(chm => chm.ChatId).IsRequired();

            builder.Property(chm => chm.SenderId).IsRequired();
            builder.Property(chm => chm.Text).IsRequired();

            builder.Property(chm => chm.SentAt).IsRequired();

            builder.HasOne(chm => chm.Sender)
                .WithMany()
                .HasForeignKey(chm=> chm.SenderId)
                .HasPrincipalKey(u => u.Id)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
