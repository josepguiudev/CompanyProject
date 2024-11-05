using MiApiCompany.Models;
using Microsoft.EntityFrameworkCore;

namespace MiApiCompany
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<User> Usuarios { get; set; }
    }
}
