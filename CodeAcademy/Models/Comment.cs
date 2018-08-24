using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Comment<T> where T:PostBase
    {
        public int PostId { get; set; } 
    }
}
