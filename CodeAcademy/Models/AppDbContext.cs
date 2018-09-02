using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class AppDbContext:IdentityDbContext<User>
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Faculty> Faculties { get; set; }   
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Tag> Tags { get; set; }    
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseCompletionStatus> CourseCompletionStatuses { get; set; } 
        public DbSet<LessonHour> LessonHours { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<SocialProfile> SocialProfiles { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);  
        }
    }
}
