using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task22_12_2021.Models
{
    public class Comments
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Subject { get; set; }

        [Column(TypeName ="ntext")]
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }

        [ForeignKey("Blog")]
        public int BlogID { get; set; }
        public Blog Blog { get; set; }

        [ForeignKey("Comments")]
        public int CommentsID { get; set; }
        public Comments Comment { get; set; }
    }
}
