using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Areas.Edu.Models
{
    public class BookSearchModel
    {
        [Required]
        public string Name { get; set; }    
    }
}
