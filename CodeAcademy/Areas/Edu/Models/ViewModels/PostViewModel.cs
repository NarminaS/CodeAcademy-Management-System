using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Areas.Edu.Models.ViewModels
{
    public class PostViewModel
    {
        [Required]
        public string PostType { get; set; }

        [Required]
        public string UserType { get; set; }
    }
}
