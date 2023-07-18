using System;
using Microsoft.EntityFrameworkCore;
namespace examMVC.Entities
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}

