using CodeAcademy.Attributes;
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
        [EntityName(ErrorMessage = "Enter valid author name")]
        public string Author { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public short PageCount { get; set; }

        [Required]
        public int FacultyId { get; set; }  

        [Required]
        public int LanguageId { get; set; }

        [Required]
        public string Tags { get; set; }

        [Required]
        public IFormFile Cover { get; set; }

        [Required]
        public IFormFile Book { get; set; }
    }
}
