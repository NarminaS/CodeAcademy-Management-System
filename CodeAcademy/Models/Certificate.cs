using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Certificate
    {
        public int Id { get; set; }

        public string SerialNumber { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public bool IsDeleted { get; set; } 
    }
}
