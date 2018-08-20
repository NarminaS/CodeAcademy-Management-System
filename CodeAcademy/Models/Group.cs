using System;
using System.Collections.Generic;

namespace CodeAcademy.Models
{
    public class Group
    {
        public Group()
        {
            Faculty = new Faculty();
            UserGroups = new List<UserGroup>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public byte FacultyId { get; set; }
        public Faculty Faculty { get; set; }

        public byte RoomId { get; set; }
        public Room Room { get; set; }

        public List<UserGroup> UserGroups { get; set; }   
        public DateTime CreationDate { get; set; }
        
    }
}