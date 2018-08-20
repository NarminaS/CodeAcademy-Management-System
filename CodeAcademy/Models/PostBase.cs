using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class PostBase
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int LikeCount { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
