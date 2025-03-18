using DashboardProject.Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace DashboardProject.Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
