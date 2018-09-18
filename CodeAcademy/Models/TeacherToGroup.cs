using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    [Table("TeacherToGroups")]
    public class TeacherToGroup
    {
        public int Id { get; set; }
        
        public Teacher Teacher { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }

        public DateTime AddingDate { get; set; }

    }
}
