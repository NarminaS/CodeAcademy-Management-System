using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }
        public string Name { get; set; }

        public string LogoImagePath { get; set; }

        public List<Group> Groups { get; set; }

        public List<Tag> Tags { get; set; } 
    }
}
