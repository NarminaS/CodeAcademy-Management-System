using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class LessonHour
    {
        public LessonHour()
        {
            Groups = new List<Group>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Monday  { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }

        public bool IsDeleted { get; set; }

        public byte BeginHour { get; set; }
        public byte BeginMinute { get; set; }

        public byte EndHour { get; set; }
        public byte EndMinute { get; set; }

        public DateTime CreationDate { get; set; }  

        public List<Group> Groups { get; set; }
    }
}
