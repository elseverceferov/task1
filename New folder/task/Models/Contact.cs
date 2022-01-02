using System.ComponentModel.DataAnnotations;

namespace Task22_12_2021.Models
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(20)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string OpenTime { get; set; }
    }
}
