using System.ComponentModel.DataAnnotations;

namespace team3.Entities
{
    /// <summary>
    /// Isaiah Jayne
    /// This class represents one of the rows of the PhoneNumber table
    /// used when reading in a row from the database 
    /// </summary>
    public class PhoneNumber
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string phoneNumber { get; set; }
    }
}
