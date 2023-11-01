using AcmeCorporationLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace AcmeCorporationLibrary.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
        }
        
        public DbSet<SubmissionModel> Submission { get; set; }
        public DbSet<SerialNumberModel> SerialNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            GenerateInitialData(modelBuilder);
        }

        public static void GenerateInitialData(ModelBuilder modelBuilder)
        {
            // Generate and add the serial numbers to the database
            for (int i = 0; i < 100; i++)
            {
                modelBuilder.Entity<SerialNumberModel>().HasData(
                    new SerialNumberModel
                    {
                        Id = i + 1,
                        Guid = Guid.NewGuid().ToString(), // Generate your serial numbers here
                        IsActive = true,
                        ConsumeTimes = 2u
                        
                    }
                );
            }
        }
    }
}
