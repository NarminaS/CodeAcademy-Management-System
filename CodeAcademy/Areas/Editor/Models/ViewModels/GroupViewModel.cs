using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Areas.Editor.Models.ViewModels
{
    public class GroupViewModel
    {
        [Required]
        [ScaffoldColumn(true)]
        public int Id { get; set; }

        [Required]
        [MaxLength(6)]
        public string Name { get; set; }

        [Required]
        public int FacultyId { get; set; }

        [Required]
        public int RoomId { get; set; }   
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime LessonsStartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime LessonsEndDate { get; set; }    
    }
}
