using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsReleaseSystem.Models.ModelMapping
{
    public class CommentsMap : EntityTypeConfiguration<Comments>
    {
        public CommentsMap()
        {
            // Primary Key
            HasKey(c => c.CommentsId);

            // Relationship
            // News : Comments = 1 : *
            HasRequired(c => c.News).WithMany(n => n.Comments).HasForeignKey(c => c.NewsId);
            // User : Comments = 1 : *
            HasRequired(c => c.User).WithMany(u => u.Comments).HasForeignKey(c => c.UserId);

            // Property Constraints
            Property(c => c.CommentsId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Content).HasMaxLength(200).IsRequired();

        }
    }
}