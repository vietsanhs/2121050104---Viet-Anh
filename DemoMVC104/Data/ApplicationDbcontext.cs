using Microsoft.EntityFrameworkCore;
using DemoMVC104.Models;

namespace DemoMVC104.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Person> Person { get; set; }

        public DbSet<VietAnh> VietAnh { get; set; }
        public DbSet<DemoMVC104.Models.AnhViet> AnhViet { get; set; } = default!;
    }
}