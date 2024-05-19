// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;

namespace FrontEnd.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define your DbSets here
    }
}
