using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Student:User
    {
        public int CourseCompletionStatusId { get; set; }
        public CourseCompletionStatus CourseCompletionStatus { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }

        public Certificate Certificate { get; set; }    
    }
}
