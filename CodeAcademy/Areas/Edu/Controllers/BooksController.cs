using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Areas.Admin.Models.ViewModels;
using CodeAcademy.Areas.Edu.Models;
using CodeAcademy.Models;
using CodeAcademy.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademy.Areas.Edu.Controllers
{
    [Authorize(Roles = "Student,Teacher")]
    [Area("Edu")]
    public class BooksController : Controller
    {
        AppDbContext _dbContext;
        UserManager<User> _userManager;
        IHostingEnvironment _environment;

        public BooksController(AppDbContext dbContext, UserManager<User> userManager, IHostingEnvironment environment)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _environment = environment;
        }

        public IActionResult Index()
        {
            var allBooks = _dbContext.Books.Include(x => x.Image).ThenInclude(i => i.Path)
                                         .Include(x => x.Language).ThenInclude(l => l.Name)
                                         .Include(x => x.TagPosts).Include(x => x.Likes);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add( BookCreateModel model)
        {
            if (ModelState.IsValid)
            {
                string[] tags = model.Tags.Split(',');
                List<Tag> bookTags = new List<Tag>();
                foreach (var tag in tags)
                {
                    Tag t = await _dbContext.Tags.FirstOrDefaultAsync(x => x.Name == tag.Trim());
                    bookTags.Add(t);
                }

                Image img = new Image() { Path = Path.Combine("/images", model.Cover.FileName) };
                await _dbContext.Images.AddAsync(img);

                await Uploader.UploadToServer(new Uploader(_environment).DefineBookPath(model.Book), model.Book);
                await Uploader.UploadToServer(new Uploader(_environment).DefineImagePath(model.Cover), model.Cover);

                Book book = new Book()
                {
                    Author = model.Author,
                    CreationDate = DateTime.Now,
                    Description = model.Description,
                    LanguageId = model.LanguageId,
                    PageCount = model.PageCount,
                    Name = model.Name,
                    FilePath = Path.Combine("/books",model.Book.FileName),
                    Image = img,
                    User = await _userManager.Users.FirstOrDefaultAsync(x=>x.Email== HttpContext.User.Identity.Name)
                };

                List<TagPost> tagPosts = new List<TagPost>();
                foreach (var tag in bookTags)
                {
                   tagPosts.Add(new TagPost() { Post = book, Tag = tag });
                }

                book.TagPosts = tagPosts;

                if (await _dbContext.AddAsync(book) != null)
                {
                    if (await _dbContext.SaveChangesAsync() > 0)
                    {
                        return Json("Book successuly added");
                    }
                }
                else
                {
                    return Json("Wrong!!!");
                }
            }
            return Json("ok");
        }

        [HttpPost]
        public async Task<IActionResult> GetTagsByFacultyId(int id)
        {
            //Student current = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name) as Student;
            var tags = await _dbContext.Tags.Where(x => x.FacultyId == id).ToListAsync();
            return Json(tags);
        }

        [HttpGet]
        public IActionResult GetFaculties()
        {
            var data = _dbContext.Faculties.Select(x => new FacultyViewModel() { Id = x.Id, Name = x.Name }).ToList();
            return Json(data);
        }

        [HttpGet]
        public IActionResult GetLanguages()
        {
            var data = _dbContext.Languages.Select(x => new FacultyViewModel() { Id = x.Id, Name = x.Name }).ToList();
            return Json(data);
        }
    }
}