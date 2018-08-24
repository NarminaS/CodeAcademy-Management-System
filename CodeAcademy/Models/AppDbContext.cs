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

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Faculty>().Property(x => x.Id).UseSqlServerIdentityColumn();
        }
    }
}
