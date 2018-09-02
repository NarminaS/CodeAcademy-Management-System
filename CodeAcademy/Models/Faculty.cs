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
            Teachers = new List<Teacher>();
            Tags = new List<Tag>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int ImageId { get; set; }
        public Image Image { get; set; }    

        public short HourCount { get; set; }

        public bool IsDeleted { get; set; }

        public List<Group> Groups { get; set; }

        public List<Teacher> Teachers { get; set; } 

        public List<Tag> Tags { get; set; }
    }
}
