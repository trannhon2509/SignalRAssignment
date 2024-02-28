﻿using Assignment2.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignalRAssignment.Models
{
    public class Supplier
    {
        [Key]
        [Required]
        public Guid SupplierID { get; set; }

        [Required(ErrorMessage ="This field is required.")]
        [Column(TypeName = "nvarchar(100)")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Column(TypeName = "nvarchar(20)")]
        [PhoneNumberValidation]
        public string Phone { get; set; }

        ICollection<Product> Products { get; set; }
    }
}
