using Microsoft.EntityFrameworkCore;
using SaaS.Api.Models;

namespace SaaS.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<MembershipRole> MembershipRoles { get; set; }
    }
}
