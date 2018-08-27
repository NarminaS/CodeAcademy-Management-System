using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Group
    {
        public Group()
        {
            Teacher = new Teacher();
            Faculty = new Faculty();
            Students = new List<Student>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }    

        public int RoomId { get; set; }
        public Room Room { get; set; }

        public int LessonHourId { get; set; }
        public LessonHour LessonHour { get; set; }

        public List<Student>Students { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LessonsStartDate { get; set; }

        public DateTime LessonsEndDate { get; set; }

        public bool IsAssembled { get; set; }
    }
}
