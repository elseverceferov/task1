using System.ComponentModel.DataAnnotations;

namespace Task22_12_2021.Models
{
    public class Social
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(250)]
        public string Icon { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Link { get; set; }
    }
}
