using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SaaS.Api.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Username { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        // For development only. In production, use proper hashing.
        [Required]
        public string Password { get; set; }

        // Foreign keys for role and membership
        public int RoleId { get; set; }
        public Role Role { get; set; }
        
        public int MembershipRoleId { get; set; }
        public MembershipRole MembershipRole { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
