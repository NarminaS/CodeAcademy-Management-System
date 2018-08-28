using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Areas.Admin.Models.ViewModels
{
    public class LessonHourCreateViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}
