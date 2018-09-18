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
        
        [MaxLength(20)]
        public string InnerText { get; set; }

        [MaxLength(60)]
        public string Description { get; set; } 
    }
}
