using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class User:IdentityUser
    {
        public User()
        {
            UserGroups = new List<UserGroup>(); 
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }

        public byte GenderId { get; set; }
        public Gender Gender { get; set; }  

        public string ProfilePhotoPath { get; set; }
        public string AcademyEmail { get; set; }

        public List<UserGroup> UserGroups { get; set; }

        public DateTime CreatingDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsActive { get; set; }

    }

}
