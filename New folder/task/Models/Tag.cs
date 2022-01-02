using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Task22_12_2021.Models
{
    public class Tag
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }
        public List<TagToBlog> TagToBlogs { get; set; }

    }
}
