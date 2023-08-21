using SimpleTracker.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace SimpleTracker.Web.Data
{
    public class SimpleTrackerContext : DbContext
    {
        public SimpleTrackerContext(DbContextOptions<SimpleTrackerContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<ModelClient> Client { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public DbSet<History> History { get; set; }
    }
}