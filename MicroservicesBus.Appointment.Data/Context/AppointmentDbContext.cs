using Microsoft.EntityFrameworkCore;
using System.Reflection;
using MicroservicesBus.Appointment.Domain.Models;

namespace MicroservicesBus.Appointment.Data.Context
{
    public class AppointmentDbContext : DbContext
    {
        public AppointmentDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppointmentEntity> Appointments { get; set; }
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
