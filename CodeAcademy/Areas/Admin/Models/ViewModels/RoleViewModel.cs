using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Areas.Admin.Models.ViewModels
{
    public class RoleViewModel
    {
        [Required]
        [ScaffoldColumn(true)]
        public string Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        public int UsersInRoleCount { get; set; }   
    }
}
