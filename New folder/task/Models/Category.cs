using System.ComponentModel.DataAnnotations;

namespace Task22_12_2021.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
    }
}
