using Microsoft.EntityFrameworkCore;

namespace AcmeCorporationLibrary.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
        }
        //DbSet<SerialNumber>
    }
}
