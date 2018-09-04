using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class SocialProfile
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public int ImageId { get; set; }
        public Image Image { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public bool IsDeleted { get; set; }
    }
}
