using Microsoft.EntityFrameworkCore;


namespace Habble.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Application>? Applications { get; set; }

    }
}
