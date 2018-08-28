using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Link:Post
    {
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
