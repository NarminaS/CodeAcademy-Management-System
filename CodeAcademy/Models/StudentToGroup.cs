using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    [Table("StudentToGroups")]
    public class StudentToGroup
    {
        public int Id { get; set; }

        public Student Student { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }

        public DateTime AddingDate { get; set; }
    }
}
