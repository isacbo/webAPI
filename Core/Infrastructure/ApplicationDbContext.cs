using Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Core.Infrastructure
{
    public interface IApplicationDbContext
    {
        DbSet<Speaker> Speakers { get; set; }
        
    }

    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Speaker> Speakers { get; set; }

        
    }
}
