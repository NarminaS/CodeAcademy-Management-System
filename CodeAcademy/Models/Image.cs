using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Image
    {
        public int Id { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public bool IsDeleted { get; set; }

        public string Path { get; set; }    
    }
}
