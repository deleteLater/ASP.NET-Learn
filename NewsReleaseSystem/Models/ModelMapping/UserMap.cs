using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsReleaseSystem.Models.ModelMapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            HasKey(u => u.UserId);

            // Relationships
            HasMany(u => u.Comments).WithRequired(c => c.User).WillCascadeOnDelete();

            // Property Constraints
            Property(u => u.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(u => u.Name).IsUnicode().IsRequired().HasMaxLength(20);
            Property(u => u.Password).IsRequired().HasMaxLength(15);
            Property(u => u.Email).IsRequired();

            // Table && Column Mapping
            ToTable("User", "dbo");

            // Ignore
            // Ignore(u => u.prop);
        }
    }
}