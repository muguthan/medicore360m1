using medicore360m1.Model;
using Microsoft.EntityFrameworkCore;

namespace medicore360m1.Data
{
    public class ApplicationDbContext : DbContext
    {
     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
    }


    

    }
