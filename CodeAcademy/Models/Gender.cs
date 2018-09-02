using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    [Table("Genders")]
    public class Gender
    {
        public Gender()
        {
            Users = new List<User>();
        }
        
        public byte Id { get; set; }

        public string Name { get; set; }

        public List<User> Users { get; set; }

        public bool IsDeleted { get; set; } 
    }
}
