using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsReleaseSystem.Models.ModelMapping
{
    public class NewsMap : EntityTypeConfiguration<News>
    {
        public NewsMap()
        {
            // Primary Key
            HasKey(n => n.NewsId);

            // Relationship
            HasMany(n => n.Comments).WithRequired(c => c.News).WillCascadeOnDelete();

            // Property Constraints
            Property(n => n.NewsId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(n => n.Title).IsRequired().HasMaxLength(50);
            Property(n => n.Content).IsUnicode().IsRequired();

            // Table && Column Mapping
            ToTable("News", "dbo");

            // Ignore
            // Ignore(n => n.prop);
        }
    }
}