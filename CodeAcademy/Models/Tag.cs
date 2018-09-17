using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Tag
    {
        public Tag()
        {
            TagPosts=new List<TagPost>();
        }

        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }

        public bool IsDeleted { get; set; }

        public List<TagPost> TagPosts { get; set; } 
    }
}
