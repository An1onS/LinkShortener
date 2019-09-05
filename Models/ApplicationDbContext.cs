using LinkShortener.Models;
using Microsoft.EntityFrameworkCore;

namespace LinkShortener
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Link> Links { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySql("server=localhost;UserId=root;Password=root;database=links;");
		}
	}
}