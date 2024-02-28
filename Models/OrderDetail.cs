using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignalRAssignment.Models
{
    public class OrderDetail
    {
        [Key]
        [Required]
        public Guid OrderDetailID { get; set; }

        public Guid OrderID { get; set; }

        public Guid ProductID { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        // Navigation properties to represent the relationships
        public Order Order { get; set; }
        public Product Product { get; set; }


    }
}
