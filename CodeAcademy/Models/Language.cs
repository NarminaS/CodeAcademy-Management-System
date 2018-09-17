using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeAcademy.Models
{
    public class Language
    {
        public Language()
        {
            Books = new List<Book>();
        }

        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public List<Book> Books { get; set; }   
    }
}