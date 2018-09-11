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

        [Required]
        public bool Monday { get; set; }

        [Required]
        public bool Tuesday { get; set; }

        [Required]
        public bool Wednesday { get; set; }

        [Required]
        public bool Thursday { get; set; }

        [Required]
        public bool Friday { get; set; }

        [Required]
        public bool Saturday { get; set; }

        [Required]
        public bool Sunday { get; set; }

        [DataType(DataType.Time)]
        public DateTime BeginTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

    }
}
