using CodeAcademy.Areas.Editor.Models.ViewModels;
using CodeAcademy.Models;
using CodeAcademy.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Areas.Edu.Models.ViewModels
{
    public class ArticleViewModel:PostViewModel
    {
        public ArticleViewModel(Article article)
        {
            this.Id = article.Id;
            this.Header = article.Header;
            this.Text = article.Text;
            this.ArticleImages = GetArticleImages(article);
            this.Tags = article.TagPosts.Select(x => new TagViewModel { Id = x.TagId, Name = x.Tag.Name }).ToList();
            this.LikeCount = article.Likes.Count;
            this.CreationDate = article.CreationDate;
            this.UserMail = article.User.Email;
            this.UserName = article.User.Name;
            this.UserSurname = article.User.Surname;
            this.UserImagePath = article.User.ProfileImage.Path;
            this.UserType = article.User.UserType;
            this.PostType = article.PostType;
        }

        [Required]
        public int Id { get; set; }

        [Required]
        public string Header { get; set; }

        [Required]
        public string Text { get; set; }

        public List<ImageViewModel> ArticleImages { get; set; }

        [Required]
        public List<TagViewModel> Tags { get; set; }

        [Required]
        public int LikeCount { get; set; }  

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public string UserMail { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string UserSurname { get; set; }

        [Required]
        public string UserImagePath { get; set; }

        public string StudentGroup { get; set; }

        private List<ImageViewModel> GetArticleImages(Article article)
        {
            return article.PostImages.Select(x => new ImageViewModel { Id = x.Id, Path = x.Path }).ToList();
        }

    }
}
