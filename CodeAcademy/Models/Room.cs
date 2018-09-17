using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [MaxLength(20)]
        public string Name { get; set; }

        public byte Capacity { get; set; }  

        public bool IsDeleted { get; set; }

        public List<Group> Groups { get; set; }
    }
}
