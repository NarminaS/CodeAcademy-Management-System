using System.Collections.Generic;

namespace CodeAcademy.Models
{
    public class Language
    {
        public Language()
        {
            Books = new List<Book>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public List<Book> Books { get; set; }   
    }
}