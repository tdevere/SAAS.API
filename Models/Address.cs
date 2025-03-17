using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaaS.Api.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Street { get; set; }
        
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        // Foreign key to User
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
