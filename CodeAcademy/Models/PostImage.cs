
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class PostImage : Image
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
