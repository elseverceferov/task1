using System.ComponentModel.DataAnnotations;

namespace Task22_12_2021.Models
{
    public class Setting
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(250)]
        public string Logo { get; set; }

        [MaxLength(250)]
        public string Address { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(30)]
        public string Email { get; set; }
    }
}
