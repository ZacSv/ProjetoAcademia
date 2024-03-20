using ProjetoSiteAcademia.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoSiteAcademia.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
    }
}
