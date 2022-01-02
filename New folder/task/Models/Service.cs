using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task22_12_2021.Models
{
    public class Service
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [Column(TypeName ="ntext")]
        public string Content { get; set; }

        public DateTime CreateTiem { get; set; }
    }
}
