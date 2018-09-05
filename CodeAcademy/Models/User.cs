using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class User:IdentityUser
    {
        public User()
        {
            SocialProfiles = new List<SocialProfile>();
            Posts = new List<Post>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }

        public byte GenderId { get; set; }
        public Gender Gender { get; set; }

        public int ImageId { get; set; }    
        public ProfileImage ProfileImage { get; set; }    

        public DateTime CreatingDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public DateTime LastLoginDate { get; set; }

        public bool IsBlocked { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public List<SocialProfile> SocialProfiles { get; set; }

        public List<Post> Posts { get; set; }

        public List<Like> Likes { get; set; }
    }

}
