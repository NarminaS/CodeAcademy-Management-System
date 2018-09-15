using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Book:Post
    {
        public string Author { get; set; } 

        public string Name { get; set; }

        public string Description { get; set; }

        public short PageCount { get; set; } 

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public string FilePath { get; set; }    

        public bool IsApproved { get; set; }

        public int ImageId { get; set; }
        public Image Image { get; set; }
    }
}
