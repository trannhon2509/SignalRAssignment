using System.ComponentModel.DataAnnotations;

namespace SignalRAssignment.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [MaxLength(50)]
        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}
