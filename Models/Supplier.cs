using System.ComponentModel.DataAnnotations;

namespace SignalRAssignment.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [Required]
        [MaxLength(100)]
        public string CompanyName { get; set; }

        public string Address { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }
    }
}
