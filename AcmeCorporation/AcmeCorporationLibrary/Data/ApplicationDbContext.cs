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
    }
}
