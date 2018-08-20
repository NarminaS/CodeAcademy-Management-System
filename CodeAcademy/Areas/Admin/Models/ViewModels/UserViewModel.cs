using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Areas.Admin.Models.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }  
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public byte GenderId { get; set; }
    }
}
