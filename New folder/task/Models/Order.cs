using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task22_12_2021.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(20)]
        public string Email { get; set; }

        [Column(TypeName ="ntext")]
        public string Text { get; set; }

    }
}
