using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Teacher:User
    {
        public Teacher()
        {
            Groups = new List<Group>();
            Faculty = new Faculty();
        }

        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }

        public List<Group> Groups { get; set; }
    }
}
