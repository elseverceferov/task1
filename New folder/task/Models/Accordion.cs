using System.ComponentModel.DataAnnotations;

namespace Task22_12_2021.Models
{
    public class Accordion
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(2000)]
        public string Content { get; set; }
    }
}
