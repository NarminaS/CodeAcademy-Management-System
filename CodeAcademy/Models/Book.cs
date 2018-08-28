using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Book:Post
    {
        public Book()
        {
            Language = new Language();
        }
        public string Author { get; set; } //Class?? List???
        public string Name { get; set; }
        public string Description { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public bool IsApproved { get; set; }
        public string CoverImagePath { get; set; }  
    }
}
