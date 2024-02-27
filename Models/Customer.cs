using System.ComponentModel.DataAnnotations;

namespace SignalRAssignment.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ContactName { get; set; }

        public string Address { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
    }
}
