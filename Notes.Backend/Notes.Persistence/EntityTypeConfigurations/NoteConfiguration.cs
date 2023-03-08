using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notes.Domain;

/// Settings for Note (entity), just not to write that all 
/// in method OnModelCreating()

namespace Notes.Persistence.EntityTypeConfigurations
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(n => n.Id);
            builder.HasIndex(n => n.Id).IsUnique();

            builder.Property(n => n.Title).HasMaxLength(250);
            builder.Property(n => n.Title).IsRequired();

            builder.Property(n => n.Text).HasMaxLength(3000);

        }
    }
}
