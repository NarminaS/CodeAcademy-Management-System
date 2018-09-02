using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Tag
    {
        public Tag()
        {
            Faculty = new Faculty();
            TagPosts=new List<TagPost>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }

        public bool IsDeleted { get; set; }

        public List<TagPost> TagPosts { get; set; } 
    }
}
