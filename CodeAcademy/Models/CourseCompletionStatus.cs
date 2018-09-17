using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    [Table(name:"CourseCompletionStatuses")]
    public class CourseCompletionStatus
    {
        public CourseCompletionStatus()
        {
            Students = new List<Student>();
        }
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public List<Student> Students { get; set; } 
    }
}
