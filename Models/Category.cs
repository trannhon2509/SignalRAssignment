using System.ComponentModel.DataAnnotations;

namespace SignalRAssignment.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "CategoryName is required!")]
        [MaxLength(50)]
        public string CategoryName { get; set; }
        [MaxLength(250 , ErrorMessage = "Description from 0 - 250 character.")]
        public string Description { get; set; }
    }
}
