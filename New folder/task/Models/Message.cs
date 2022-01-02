using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task22_12_2021.Models
{
    public class Message
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Email_address { get; set; }

        [MaxLength(150)]
        public string Subject { get; set; }

        [Column(TypeName ="ntext")]
        public string Text { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
