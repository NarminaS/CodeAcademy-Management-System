using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class TagPost
    {
        public TagPost()
        {
            Tag = new Tag();
            Post = new Post();
        }
        public int TagId { get; set; }
        public Tag Tag { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }  
    }
}
