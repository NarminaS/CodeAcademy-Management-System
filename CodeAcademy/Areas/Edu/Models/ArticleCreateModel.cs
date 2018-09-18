using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Areas.Edu.Models
{
    public class ArticleCreateModel
    {
        [Required]
        public string Header { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Tags { get; set; }

        public IFormFileCollection Files { get; set; }
    }
}
