using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Speaker> Speakers { get; set; }
    }
}
