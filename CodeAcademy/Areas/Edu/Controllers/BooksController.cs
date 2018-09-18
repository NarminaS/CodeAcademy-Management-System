using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Areas.Admin.Models.ViewModels;
using CodeAcademy.Areas.Edu.Models;
using CodeAcademy.Areas.Edu.Models.ViewModels;
using CodeAcademy.Models;
using CodeAcademy.Models.ViewModels;
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
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(BookCreateModel model)
        {
            if (ModelState.IsValid)
            {
                string[] tags = model.Tags.Split(',');
                List<Tag> bookTags = new List<Tag>();
                foreach (var tag in tags)
                {
                    Tag t = await _dbContext.Tags.FirstOrDefaultAsync(x => x.Name.ToLower() == tag.Trim().ToLower());
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
                    Language = await _dbContext.Languages.FirstOrDefaultAsync(x=>x.Id==model.LanguageId),
                    PageCount = model.PageCount,
                    Name = model.Name,
                    FilePath = Path.Combine("/books", model.Book.FileName),
                    Image = img,
                    Faculty = await _dbContext.Faculties.FirstOrDefaultAsync(x => x.Id == model.FacultyId),
                    User = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == HttpContext.User.Identity.Name)
                };

                List<TagPost> tagPosts = new List<TagPost>();
                foreach (var tag in bookTags)
                {
                    tagPosts.Add(new TagPost() { Post = book, Tag = tag });
                }

                book.TagPosts = tagPosts;

                if (await _dbContext.Books.AddAsync(book) != null)
                {
                    if (await _dbContext.SaveChangesAsync() > 0)
                    {
                        return Json(new BookViewModel(book));
                    }
                }
                else
                {
                    return Json("Wrong!!!");
                }
            }
            else
            {
                ModelState.AddModelError("","Check your inputs");
            }
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var allBooks = await _dbContext.Books.Include(x => x.Image)
                                                    .Include(x => x.Language)
                                                       .Include(x => x.TagPosts).ThenInclude(t=>t.Tag)
                                                          .Include(x => x.Likes)
                                                             .ToListAsync();
            var model = allBooks.Select(x => new BookViewModel(x)).ToList();
            return Json(model);
        }

        [HttpPost]
        public async Task<IActionResult> GetTagsByFacultyId(int id)
        {
            var tags = await _dbContext.Tags.Where(x => x.FacultyId == id)
                                            .Select(d => new DropdownViewModel { Id = d.Id, Name = d.Name })
                                            .ToListAsync();
            return Json(tags);
        }

        [HttpGet]
        public IActionResult GetFaculties()
        {
            var data = _dbContext.Faculties.Select(x => new DropdownViewModel() { Id = x.Id, Name = x.Name }).ToList();
            return Json(data);
        }

        [HttpGet]
        public IActionResult GetLanguages()
        {
            var data = _dbContext.Languages.Select(x => new DropdownViewModel() { Id = x.Id, Name = x.Name }).ToList();
            return Json(data);
        }

        [HttpPost]
        public async Task<IActionResult> GetBooksByFaculty(int facultyId)
        {
            var books = await _dbContext.Books.Where(x => x.FacultyId == facultyId)
                                              .Include(x => x.Language)
                                              .Include(x => x.TagPosts).ThenInclude(t => t.Tag)
                                              .Include(x => x.Image)
                                              .Include(x => x.Likes)
                                              .ToListAsync();

            var data = books.Select(x => new BookViewModel(x));
            return Json(data);
        }

        [HttpPost]
        public async Task<IActionResult> GetBooksByLanguage(int languageId)
        {
            var books = await _dbContext.Books.Where(x => x.LanguageId == languageId)
                                  .Include(x => x.Language)
                                  .Include(x => x.TagPosts).ThenInclude(t => t.Tag)
                                  .Include(x => x.Image)
                                  .Include(x => x.Likes)
                                  .ToListAsync();

            var data = books.Select(x => new BookViewModel(x));
            return Json(data);
        }

        [HttpPost]
        public async Task<IActionResult> SearchBookByName(BookSearchModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _dbContext.Books.Include(x => x.Image)
                                                    .Include(x => x.Language)
                                                    .Include(x => x.TagPosts).ThenInclude(t=>t.Tag)
                                                    .Include(x => x.Likes)
                                                    .Where(x => x.Name.ToLower().Contains(model.Name.ToLower()))
                                                    .Select(x => new BookViewModel(x))
                                                    .ToListAsync();
                return Json(result);
            }
            return Json("No books found...");
        }
    }
}