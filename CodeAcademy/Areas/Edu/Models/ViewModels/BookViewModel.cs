using CodeAcademy.Areas.Editor.Models.ViewModels;
using CodeAcademy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Areas.Edu.Models.ViewModels
{
    public class BookViewModel
    {
        public BookViewModel(Book book)
        {
            this.Id = book.Id;
            this.Name = book.Name;
            this.Author = book.Author;
            this.Description = book.Description;
            this.Language = book.Language.Name;
            this.PageCount = book.PageCount;
            this.ImagePath = book.Image.Path;
            this.FilePath = book.FilePath;
            this.LikeCount = book.Likes.Count;
            this.Tags = book.TagPosts.Select(x => new TagViewModel{ Id = x.TagId,  Name = x.Tag.Name}) .ToList();
        }
        public  int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Language { get; set; }

        public short PageCount { get; set; }    

        public string ImagePath { get; set; }

        public string FilePath { get; set; }

        public int LikeCount { get; set; }

        public List<TagViewModel> Tags { get; set; }
    }
}
