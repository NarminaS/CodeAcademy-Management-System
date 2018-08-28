using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Room
    {
        public Room()
        {
            Groups = new List<Group>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Group> Groups { get; set; }
    }
}
