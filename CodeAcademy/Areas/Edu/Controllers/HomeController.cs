using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Areas.Edu.Models;
using CodeAcademy.Areas.Edu.Models.ViewModels;
using CodeAcademy.Models;
using CodeAcademy.Models.ViewModels;
using CodeAcademy.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace CodeAcademy.Areas.Edu.Controllers
{
    [Authorize(Roles = "Student,Teacher")]
    [Area("Edu")]
    public class HomeController : Controller
    {
        AppDbContext _dbContext;
        UserManager<User> _userManager;
        IHostingEnvironment _hostingEnvironment;

        public HomeController(AppDbContext dbContext, UserManager<User> userManager, IHostingEnvironment hostingEnvironment)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAllPosts()
        {
            List<Post> posts = new List<Post>();
            var allArticles = await _dbContext.Articles
                                 .Include(x => x.TagPosts).ThenInclude(t => t.Tag)
                                 .Include(x => x.PostImages)
                                 .Include(x => x.Likes)
                                 .Include(x => x.User).ThenInclude(x => x.ProfileImage)
                                 .Select(x => new ArticleViewModel(x)).ToListAsync();

            var allQuestions = await _dbContext.Questions
                                    .Include(x => x.User)
                                    .Include(x => x.TagPosts).ThenInclude(t => t.Tag).Include(x => x.PostImages).Include(x => x.Likes).ToListAsync();
            var allLinks = await _dbContext.Links
                                    .Include(x => x.User)
                                    .Include(x => x.TagPosts).ThenInclude(t => t.Tag).Include(x => x.TagPosts).Include(x => x.Likes).ToListAsync();
            var allBooks = await _dbContext.Books
                                    .Include(x => x.Image)
                                    .Include(x => x.Language).Include(x => x.TagPosts).ThenInclude(t => t.Tag).Include(x => x.Likes).ToListAsync();
            //posts.AddRange(allArticles);
            //posts.AddRange(allQuestions);
            //posts.AddRange(allLinks);
            //posts.AddRange(allBooks);
            posts.OrderBy(x => x.CreationDate);
            return Json(posts);
        }

        public async Task<IActionResult> GetAllArticles()
        {
            List<ArticleViewModel> articles = new List<ArticleViewModel>();

            try
            {
                articles = await _dbContext.Articles
                                 .Include(x => x.TagPosts).ThenInclude(t => t.Tag)
                                 .Include(x => x.PostImages)
                                 .Include(x => x.Likes)
                                 .Include(x => x.User).ThenInclude(x => x.ProfileImage)
                                 .Select(x => new ArticleViewModel(x)).ToListAsync();

                foreach (var a in articles)
                {
                    if (a.UserType=="Student")
                    {
                        a.StudentGroup = GetUserGroup(a.UserMail,_dbContext);
                    }
                }


            }
            catch (Exception ex)
            {
                //...
            }
           
            return Json(articles);
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticle(ArticleCreateModel model)
        {
            if (ModelState.IsValid)
            {
                string[] tags = model.Tags.Split(',');
                List<Tag> articleTags = new List<Tag>();
                foreach (var tag in tags)
                {
                    Tag t = await _dbContext.Tags.FirstOrDefaultAsync(x => x.Name.ToLower() == tag.Trim().ToLower());
                    articleTags.Add(t);
                }

                List<PostImage> postImages = new List<PostImage>();
                if (model.Files != null)
                {
                    foreach (var file in model.Files)
                    {
                        PostImage img = new PostImage() { Path = Path.Combine("/images/posts", file.FileName) };
                        postImages.Add(img);
                        await _dbContext.Images.AddAsync(img);
                        await Uploader.UploadToServer(new Uploader(_hostingEnvironment).DefinePostImagePath(file), file);
                    }
                }
                Article article = new Article()
                {
                    Header = model.Header,
                    Text = model.Description,
                    CreationDate = DateTime.Now,
                    Faculty = GetUserFaculty( this.GetLoggedUser(_dbContext)),
                    User =  this.GetLoggedUser(_dbContext),
                    PostImages = postImages
                };

                List<TagPost> artTags = new List<TagPost>();
                foreach (var tag in articleTags)
                {
                    artTags.Add(new TagPost() { Post = article, Tag = tag });
                }

                article.TagPosts = artTags;

                if (await _dbContext.Articles.AddAsync(article) != null)
                {
                    if (await _dbContext.SaveChangesAsync() > 0)
                    {
                        ArticleViewModel viewModel = new ArticleViewModel(article);
                        if (article.User.UserType=="Student")
                        {
                            viewModel.StudentGroup = GetUserGroup(article.User.Email, _dbContext);
                        }
                        return Json(viewModel);
                    }
                }
               else
                {
                    return Json("Error adding new article");
                }
            }
            else
            {
                return Json("Wrong model");
            }
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> LikePost(int postId)
        {
            User current =  this.GetLoggedUser(_dbContext);

            Post postToLike = await _dbContext.Posts.Include(l=>l.Likes)
                                                    .Include(u=>u.User)
                                                    .FirstOrDefaultAsync(x => x.Id == postId);

            Like currentLike = await _dbContext.Likes.SingleOrDefaultAsync(x => x.PostId == postId && x.UserId == current.Id);

            if (current.Id == postToLike.User.Id)
            {
                return Json("You can't like your own post");
            }

            if (currentLike == null)
            {
                Like like = new Like() { User = current, Post = postToLike, LikeDate = DateTime.Now };
                if (await _dbContext.Likes.AddAsync(like) != null)
                {
                    current.Likes.Add(like);
                    if (await _dbContext.SaveChangesAsync() > 0)
                    {
                        currentLike = like;
                        return Json(postToLike.Likes.Count);
                    }
                }
            }
            else
            {
                _dbContext.Likes.Remove(currentLike);
                await _dbContext.SaveChangesAsync();
            }
            return Json(postToLike.Likes.Count);
        }


        private Faculty GetUserFaculty(User user)
        {
            if (_userManager.IsInRoleAsync(user,"Student").Result)
            {
                return  _dbContext.Students
                                          .Include(g => g.Group)
                                          .ThenInclude(f => f.Faculty)
                                          .FirstOrDefaultAsync(x=>x.Email==user.Email)
                                          .Result.Group.Faculty;
            }
            if (_userManager.IsInRoleAsync(user, "Teacher").Result)
            {
                return _dbContext.Teachers
                                          .Include(g => g.Faculty)
                                          .FirstOrDefaultAsync(x => x.Email == user.Email)
                                          .Result.Faculty;
            }
            return default;
        }

        [HttpGet]
        public IActionResult GetTags()
        {
            var data = _dbContext.Tags.Select(x => new DropdownViewModel() { Id = x.Id, Name = x.Name }).ToList();
            return Json(data);
        }

        private string GetUserGroup(string email, AppDbContext dbContext)
        {
                var t = Task.Factory.StartNew(() => dbContext.Students.Where(x => x.Email == email).Include(x => x.Group).SingleOrDefaultAsync()
                .Result.Group.Name);
                var r = t.Result;
                return r;
        }

    }
}