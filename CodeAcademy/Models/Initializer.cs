using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class RoleInitializer
    {
        public static async Task SeedGenders(AppDbContext context)
        {
            if (!context.Genders.Any())
            {
                var male = new Gender { Id = 1, Name = "Male" };
                var female = new Gender { Id = 2, Name = "Female" };
                await context.AddRangeAsync(male, female);
                await context.SaveChangesAsync();
            }
        }
        public static async Task InitializeAsync(UserManager<User> userManager,RoleManager<IdentityRole> roleManager)
        {
            string adminMail = "admin@code.edu.az";
            string adminPassword = "A_a123456";

            if (await roleManager.FindByNameAsync("Admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            if (await roleManager.FindByNameAsync("Editor") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Editor"));
            }

            if (await userManager.FindByNameAsync(adminMail) == null)
            {
                User admin = new User
                {
                    Email = adminMail,
                    UserName = adminMail,
                    GenderId = 1,
                    ProfilePhotoPath = "/images/avatars/avatar-default.png",
                    Name = "Administrator",
                    IsActive = true,
                    CreatingDate = DateTime.Now
                };

                IdentityResult result = await userManager.CreateAsync(admin, adminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "Admin");
                }
            }
        }
    }
}