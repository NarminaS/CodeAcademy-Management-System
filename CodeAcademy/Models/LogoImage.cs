using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class LogoImage: Image
    {
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }    
    }
}
