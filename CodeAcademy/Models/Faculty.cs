using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Faculty
    {
        public Faculty()
        {
            Groups = new List<Group>();
        }
        public byte Id { get; set; }
        public int Name { get; set; }

        public List<Group> Groups { get; set; } 

    }
}
