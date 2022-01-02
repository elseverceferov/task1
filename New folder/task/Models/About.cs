using System.ComponentModel.DataAnnotations;

namespace Task22_12_2021.Models
{
    public class About
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }
    }
}
