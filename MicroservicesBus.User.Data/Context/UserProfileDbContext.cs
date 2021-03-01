using MicroservicesBus.User.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MicroservicesBus.User.Data.Context
{
    public class UserProfileDbContext : DbContext
    {
        public UserProfileDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Seed();

            //modelBuilder.Entity<UserProfile>().Property(p => p.AreaOfCoverage)
            //.HasConversion(
            //    v => JsonConvert.SerializeObject(v),
            //    v => JsonConvert.DeserializeObject<List<string>>(v));

        }
    }
}
