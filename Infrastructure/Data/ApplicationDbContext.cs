using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Sensor> Sensors { get; set; }

        public DbSet<SensorValue> SensorValues { get; set; }

        public DbSet<Device> Devices { get; set; }

        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite($"Data Source={Environment.CurrentDirectory}/Test.db");
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
