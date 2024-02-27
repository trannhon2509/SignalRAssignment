using System.ComponentModel.DataAnnotations;

namespace SignalRAssignment.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "ContactName is required")]
        public string ContactName { get; set; }
        
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone is required!")]
        [MaxLength(20)]
        public string Phone { get; set; }
    }
}
