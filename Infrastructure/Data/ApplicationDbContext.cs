using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Sensor> Sensors { get; set; }

        public DbSet<SensorValue> SensorValues { get; set; }

        public DbSet<Device> Devices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=ABUBAKR;Database=Test;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Sensor>()
                .HasOne(x => x.Device)
                .WithMany(x => x.Sensors)
                .HasForeignKey(x => x.DeviceId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<SensorValue>()
                .HasOne(x => x.Sensor)
                .WithMany(x => x.SensorValues)
                .HasForeignKey(x => x.SensorId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
