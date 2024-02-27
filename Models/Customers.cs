using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignalRAssignment.Models
{
    public class Customers
    {
        [Key]
        [Required]
        public Guid CustomerID { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage ="Password is required.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "ContactName is required")]
        public string ContactName { get; set; }
        
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone is required!")]
        [MaxLength(20)]
        public string Phone { get; set; }
    }
}
