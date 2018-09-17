using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Areas.Edu.Models.ViewModels;
using CodeAcademy.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        AppDbContext _dbContext;
        UserManager<User> _userManager;
        IHostingEnvironment _environment;

        public ValuesController(AppDbContext dbContext, UserManager<User> userManager, IHostingEnvironment environment)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _environment = environment;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetAsync()
        {
            var allBooks = await _dbContext.Books.Include(x => x.Image)
                                                     .Include(x => x.Language)
                                                        .Include(x => x.TagPosts)
                                                           .Include(x => x.Likes)
                                                              .ToListAsync();
            var model = allBooks.Select(x => new BookViewModel
            {
                Id = x.Id,
                Author = x.Author,
                Name = x.Name,
                Description = x.Description,
                Language = x.Language.Name,
                ImagePath = x.Image.Path,
                FilePath = x.FilePath,
                PageCount = x.PageCount,
                LikeCount = x.Likes.Count
            }).ToList();
            return Ok(model);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
