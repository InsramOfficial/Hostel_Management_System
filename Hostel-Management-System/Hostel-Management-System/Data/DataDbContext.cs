using Hostel_Management_System.Models;
using Hostel_Management_System.Pages.Admin;
using Microsoft.EntityFrameworkCore;

namespace Hostel_Management_System.Data
{
	public class DataDbContext : DbContext
	{
		public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
		{

		}
	
		public DbSet<Courses> courses { get; set; }
		public DbSet<Registration> registations { get; set; }

	}
}
