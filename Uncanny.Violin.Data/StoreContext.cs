using Uncanny.Violin.Domain.Catalog; 
using Microsoft.EntityFrameworkCore; 

namespace Uncanny.Violin.Data 
{
	public class StoreContext : DbContext 
	{ 
		public StoreContext(DbContextOptions<StoreContext> options)
			: base(options)
	{  }

	public DbSet<Item> Items { get; set; } 
	}
}

