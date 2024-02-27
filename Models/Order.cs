using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SignalRAssignment.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public decimal Freight { get; set; }

        public string ShipAddress { get; set; }

        public Customers Customer { get; set; }
    }
}
