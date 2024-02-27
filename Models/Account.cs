using System.ComponentModel.DataAnnotations;

namespace SignalRAssignment.Models
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }

        [Required(ErrorMessage = "Username is required!")]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Passsword is required!")]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required(ErrorMessage = "FullName is required!")]
        [MaxLength(100)]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Type is required!")])]
        [Range(0, 1)]
        public int Type { get; set; }
    }
}
