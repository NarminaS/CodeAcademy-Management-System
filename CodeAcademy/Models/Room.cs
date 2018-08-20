using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    [Table("Rooms")]
    public class Room
    {
        public Room()
        {
            Groups = new List<Group>();
        }
        public byte Id { get; set; }
        public string Name { get; set; }
        public List<Group> Groups { get; set; }
    }
}
