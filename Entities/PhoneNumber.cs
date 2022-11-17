using System.ComponentModel.DataAnnotations;

namespace team3.Entities
{
    public class PhoneNumber
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string phoneNumber { get; set; }
    }
}
