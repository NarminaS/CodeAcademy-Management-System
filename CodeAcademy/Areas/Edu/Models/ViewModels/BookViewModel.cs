using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Areas.Edu.Models.ViewModels
{
    public class BookViewModel
    {
        public  int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Language { get; set; }

        public short PageCount { get; set; }    

        public string ImagePath { get; set; }

        public string FilePath { get; set; }

        public int LikeCount { get; set; }  
    }
}
