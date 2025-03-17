using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SaaS.Api.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }  // e.g., Admin, Manager, User, Guest
        
        public string Description { get; set; }
        
        public ICollection<User> Users { get; set; }
    }
}
