using System.Data.Entity;
using NewsReleaseSystem.Models.ModelMapping;

namespace NewsReleaseSystem.Models
{
    public class CofeDbContext : DbContext
    {
        public CofeDbContext()
            : base("name=CofeConnectionString")
        {
            Database.SetInitializer<CofeDbContext>(new CreateDatabaseIfNotExists<CofeDbContext>());

            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new NewsMap());
            modelBuilder.Configurations.Add(new CommentsMap());
        }

        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}