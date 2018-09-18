using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Post
    {
        public Post()
        {
            User = new User();
            Likes = new List<Like>();
            Comments = new List<Comment>();
            TagPosts = new List<TagPost>();
            PostImages = new List<PostImage>();
        }
        public int Id { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }  

        public DateTime CreationDate { get; set; }

        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }

        public List<Like> Likes { get; set; }

        public List<Comment> Comments { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public List<TagPost> TagPosts { get; set; }

        public List<PostImage> PostImages { get; set; }

        public bool IsDeleted { get; set; }

        public string PostType { get; set; }    
    }
}
