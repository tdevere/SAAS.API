using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SaaS.Api.Models
{
    public class MembershipRole
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }  // e.g., Free, Basic, Premium, Platinum
        
        public string Description { get; set; }
        
        public ICollection<User> Users { get; set; }
    }
}
