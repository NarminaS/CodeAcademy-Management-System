using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Article:Post
    {
        public string Header { get; set; }

        public string Text { get; set; } 
    }
}
