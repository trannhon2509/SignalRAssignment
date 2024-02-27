using System.ComponentModel.DataAnnotations;

namespace SignalRAssignment.Models
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        [MaxLength(100)]
        public string FullName { get; set; }

        [Range(0, 1)]
        public int Type { get; set; }
    }
}
