using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Areas.Edu.Models.ViewModels
{
    public class ImageViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Path { get; set; }

    }
}
