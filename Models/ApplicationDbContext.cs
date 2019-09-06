using LinkShortener.Models;
using Microsoft.EntityFrameworkCore;

namespace LinkShortener
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Link> Links { get; set; }
		
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
	}
}