using System;
using Microsoft.EntityFrameworkCore;

namespace webApi.Models
{
	public class ApiContext : DbContext
	{
		public ApiContext(DbContextOptions<ApiContext> options) : base(options)
		{

		}

		public DbSet<Category> Categories { set; get; }
		public DbSet<Product> Products { set; get; }
	}
}

