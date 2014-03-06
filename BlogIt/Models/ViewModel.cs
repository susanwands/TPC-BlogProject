using BlogIt.Data.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogIt.Models
{
    public class ViewModel
    {
        public List<Blog> Blogs { get; set; }

        public List<Article> Articles { get; set; }
        public IPagedList<Article> PagedArticles { get; set; }
        public Article Article { get; set; }
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleLink { get; set; }

        public List<Post> Posts { get; set; }
        public IPagedList<Post> PagedPosts { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

    }
}