using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class ProfileImage : Image
    {
        public User User { get; set; }  
    }
}
