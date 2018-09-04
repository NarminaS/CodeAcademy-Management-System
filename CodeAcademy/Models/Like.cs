﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Like
    {
        public Like()
        {
            Post = new Post();
            User = new User();
        }
        public int Id { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public DateTime LikeDate { get; set; }  
    }
}
