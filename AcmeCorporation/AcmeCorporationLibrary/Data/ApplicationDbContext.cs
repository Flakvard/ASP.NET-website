using Microsoft.EntityFrameworkCore;

namespace AcmeCorporationWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
        }
        //DbSet<SerialNumber>
    }
}
