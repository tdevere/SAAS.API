using SaaS.Api.Models;
using System.Linq;

namespace SaaS.Api.Data
{
    public static class DatabaseSeeder
    {
        public static void Seed(AppDbContext context)
        {
            // Seed Roles if not present
            if (!context.Roles.Any())
            {
                context.Roles.AddRange(
                    new Role { Name = "Admin", Description = "Full access" },
                    new Role { Name = "Manager", Description = "Limited admin access" },
                    new Role { Name = "User", Description = "Standard user access" },
                    new Role { Name = "Guest", Description = "Read-only access" }
                );
                context.SaveChanges();
            }

            // Seed MembershipRoles if not present
            if (!context.MembershipRoles.Any())
            {
                context.MembershipRoles.AddRange(
                    new MembershipRole { Name = "Free", Description = "Basic free membership" },
                    new MembershipRole { Name = "Basic", Description = "Basic paid membership" },
                    new MembershipRole { Name = "Premium", Description = "Premium membership" },
                    new MembershipRole { Name = "Platinum", Description = "Top tier membership" }
                );
                context.SaveChanges();
            }

            // Seed Users if not present (creates one for each core role)
            if (!context.Users.Any())
            {
                var roles = context.Roles.ToDictionary(r => r.Name, r => r.Id);
                var memberships = context.MembershipRoles.ToDictionary(m => m.Name, m => m.Id);

                context.Users.AddRange(
                    new User {
                        Username = "adminuser",
                        Email = "admin@example.com",
                        Password = "admin123", // in production, use secure hashing!
                        RoleId = roles["Admin"],
                        MembershipRoleId = memberships["Platinum"]
                    },
                    new User {
                        Username = "manageruser",
                        Email = "manager@example.com",
                        Password = "manager123",
                        RoleId = roles["Manager"],
                        MembershipRoleId = memberships["Premium"]
                    },
                    new User {
                        Username = "standarduser",
                        Email = "user@example.com",
                        Password = "user123",
                        RoleId = roles["User"],
                        MembershipRoleId = memberships["Basic"]
                    },
                    new User {
                        Username = "guestuser",
                        Email = "guest@example.com",
                        Password = "guest123",
                        RoleId = roles["Guest"],
                        MembershipRoleId = memberships["Free"]
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
