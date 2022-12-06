using Microsoft.EntityFrameworkCore;

namespace RazorPagesResume.Model
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserModel> users {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //here you can MAP Your Models/Entities, but i am going to show you something more interesting. so keep up. 
           // modelBuilder.Configurations.Add(new UsersMap());
           modelBuilder.Entity<UserModel>()
                        .HasKey(p => p.Id);
        }
    }
}