using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Areas.Edu.Models
{
    public class BookCreateModel
    {
        [Required]
        public string Author { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public short PageCount { get; set; }

        [Required]
        public int LanguageId { get; set; }

        public string Tags { get; set; }

        public IFormFile Cover { get; set; }

        public IFormFile Book { get; set; }
    }
}
