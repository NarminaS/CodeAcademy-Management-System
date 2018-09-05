using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Areas.Admin.Models.ViewModels
{
    public class FacultyCreateViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public short HourCount { get; set; }
    }
}
