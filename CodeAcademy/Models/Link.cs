using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Link:Post
    {
        [DataType(DataType.Url)]
        public string Url { get; set; }
        
        public string Description { get; set; }
    }
}
