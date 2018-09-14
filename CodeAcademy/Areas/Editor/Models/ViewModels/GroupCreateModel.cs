using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Areas.Editor.Models.ViewModels
{
    public class GroupCreateModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int FacultyId { get; set; }

        [Required]
        public string TeacherId { get; set; }

        [Required]
        public int RoomId { get; set; }

        [Required]
        public int HourId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }   
    }
}
