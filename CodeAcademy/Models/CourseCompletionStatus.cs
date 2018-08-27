﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    [Table(name: "CourseCompletionStatuses")]

    public class CourseCompletionStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Student> Students { get; set; } 
    }
}
