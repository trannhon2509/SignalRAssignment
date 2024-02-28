﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SignalRAssignment.Models
{
    public class Order
    {
        [Key]
        [Required]
        public Guid OrderID { get; set; }

        public Guid CustomerID { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public decimal Freight { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Delivery address is required.")]
        public string ShipAddress { get; set; }

        public Customers Customer { get; set; }

        // Navigation property to represent the relationship with OrderDetail
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
