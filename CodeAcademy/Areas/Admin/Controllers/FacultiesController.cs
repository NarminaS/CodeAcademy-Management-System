using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Areas.Admin.Models.ViewModels;
using CodeAcademy.Models;
using CodeAcademy.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademy.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class FacultiesController : Controller
    {
        AppDbContext _dbContext;
        IHostingEnvironment _environment;

        public FacultiesController(AppDbContext dbContext, IHostingEnvironment environment)
        {
            _dbContext = dbContext;
            _environment = environment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _dbContext.Faculties
                            .Include(x=>x.Image)
                                .Select(x => new FacultyViewModel()
                                    { Id = x.Id, Name = x.Name, GroupsInFacultyCount = x.Groups.Count, LogoImagePath = x.Image.Path })
                                                    .ToList();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(string name,IFormFile file)
        {
            if (!String.IsNullOrEmpty(name) && file != null)
            {
               Image img = new Image() { Path = Path.Combine("/images", file.FileName) };
               await _dbContext.Images.AddAsync(img);
               await UploadToServer(DefinePath(file), file);

               Faculty faculty = new Faculty { Name = name, Image = img };
               await _dbContext.Faculties.AddAsync(faculty);

               int affected = await _dbContext.SaveChangesAsync();
               if (affected > 0)
                {
                    return RedirectToAction("Index", "Faculties");
                }
               else
                {
                    //SQL EXCEPTION
                }
            }
            return RedirectToAction("Index", "Faculties");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(FacultyViewModel model, IFormFile file)
        {
            var faculty = _dbContext.Faculties.Where(x => x.Id == model.Id).FirstOrDefault();

            if (ModelState.IsValid && faculty != null)
            {
                faculty.Name = model.Name;
                if (file !=null && !faculty.Image.Path.Contains(file.FileName))
                {
                    await new OldFileRemover(_environment).DeleteOldFacultyLogoAsync(faculty);
                    await UploadToServer(DefinePath(file), file);
                    faculty.Image.Path = Path.Combine("/images", file.FileName);
                }

                _dbContext.Update(faculty);

                if (await _dbContext.SaveChangesAsync() > 0)
                {
                    return RedirectToAction("Index", "Faculties");
                }
                return RedirectToAction("Index", "Faculties");
            }
            return RedirectToAction("Index", "Faculties");
        }

        [HttpPost]
        public IActionResult Deactivate(byte id)    
        {
            //Check for groups absence...
            return View();
        }

        private string DefinePath (IFormFile file)
        {
            string folderPath = Path.Combine(_environment.WebRootPath, "images", file.FileName) ;
            if (!String.IsNullOrEmpty(folderPath))
            {
                return folderPath;
            }
            return String.Empty;
            //Throw invalid file exeption...
        }

        private async Task UploadToServer(string path, IFormFile file)
        {
            try
            {
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }
            catch (IOException ex)
            {
                //Handle exception
            }
        }
    }
}