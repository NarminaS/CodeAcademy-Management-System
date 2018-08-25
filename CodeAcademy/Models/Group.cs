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
            Faculty = new Faculty();
            UserGroups = new List<UserGroup>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }

        public List<UserGroup> UserGroups { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LessonsStartDate { get; set; }

        public DateTime LessonsEndDate { get; set; }

        public bool IsAssembled { get; set; }
    }
}
