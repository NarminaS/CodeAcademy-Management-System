using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Image
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        [MaxLength(60),MinLength(5)]
        public string Path { get; set; }    
    }
}
