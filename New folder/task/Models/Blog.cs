using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task22_12_2021.Models
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [Column(TypeName ="ntext")]
        public string Content { get; set; }

        [ForeignKey("CustomUser")]
        public string CustomUserId { get; set; }
        public CustomUser CustomUser { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        [NotMapped]
        public int[] TagsId { get; set; }
        public List<TagToBlog> TagToBlogs { get; set; }
        public DateTime CreateDate { get; set; }


    }
}
