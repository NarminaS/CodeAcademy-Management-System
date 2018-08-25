using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Areas.Admin.Models.ViewModels
{
    public class FacultyViewModel
    {
        [ScaffoldColumn(true)]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        public string LogoImagePath { get; set; }

        public int GroupsInFacultyCount { get; set; }
    }
}
