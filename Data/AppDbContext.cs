using Microsoft.EntityFrameworkCore;
using ExpenseTrackerApp.Models;
using System.Collections.Generic;

namespace ExpenseTrackerApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Expenses> Expenses { get; set; }
    }
}
