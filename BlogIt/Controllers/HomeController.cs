using BlogIt.Data;
using BlogIt.Data.Models;

using BlogIt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace BlogIt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? pPage, int? aPage)
        {
            ViewModel Posts = new ViewModel();
            BlogItContext db = new BlogItContext();

            var PostPage = pPage ?? 1;
            var ArticlePage = aPage ?? 1;

            Posts.PagedPosts = db.Posts.Where(a => a.Visibilty == true).OrderBy(p => p.PostId).ToPagedList(PostPage, 3);
            Posts.PagedArticles = db.Articles.Where(a => a.Visibilty == true).OrderBy(a => a.ArticleId).ToPagedList(ArticlePage, 5);
            Posts.Blogs = db.Blogs.ToList();

           


            return View(Posts);
        }

        public ActionResult Search(string query)
        {

            BlogItContext db = new BlogItContext();
            ViewModel model = new ViewModel();
            
            model.Posts = db.Posts.Where(p => p.Content.Contains(query)  || p.Title.Contains(query)).ToList();
            model.Articles = db.Articles.Where(a => a.ArticleTitle.Contains(query)).ToList();
           

           return View(model);
           
        }
               
        public ActionResult LinkArticle(ViewModel article)
        {
            
            BlogItContext db = new BlogItContext();

            Article newArticle = db.Articles.Create();
            newArticle.ArticleTitle = article.ArticleTitle;
            newArticle.ArticleLink = article.ArticleLink;
            newArticle.BlogId = 1;
            newArticle.Visibilty = true;

            db.Articles.Add(newArticle);
            db.SaveChanges();



            return RedirectToAction("Index");
        }
        
        public ActionResult CreatePost(ViewModel post)
        {
            
            BlogItContext db = new BlogItContext();
            
            Post newPost = db.Posts.Create();
            newPost.Title = post.Title;
            newPost.Content = post.Content;
            newPost.DatePosted = DateTime.Today;
            newPost.BlogId = 1;
            newPost.Visibilty = true;

            db.Posts.Add(newPost);
            db.SaveChanges();


            return RedirectToAction("Index");
        }

        public ActionResult EditPost(int PostId)
        {

            BlogItContext db = new BlogItContext();
            ViewModel model = new ViewModel();
            model.Post = db.Posts.Find(PostId);
                

            return View(model);
        }

        [HttpPost]
        public ActionResult EditPost(Post postal)
        {

            BlogItContext db = new BlogItContext();
            Post editedPost = db.Posts.Where(p => p.PostId == postal.PostId).First();
           
            editedPost.Title = postal.Title;
            editedPost.Content = postal.Content;

            db.SaveChanges();
     
            return RedirectToAction("Index");
        }

        public ActionResult DeletePost(int PostId)
        {

            BlogItContext db = new BlogItContext();

            Post remove = db.Posts.Where(a => a.PostId == PostId).First();

            remove.Visibilty = false;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult EditArticle(int ArticleId)
        {

            BlogItContext db = new BlogItContext();

            ViewModel model = new ViewModel();

            model.Article = db.Articles.Find(ArticleId);


            return View(model);
        }

        [HttpPost]
        public ActionResult EditArticle(int ArticleId, string ArticleTitle, string ArticleLink)
        {

            BlogItContext db = new BlogItContext();
            Article editArticle = db.Articles.Where(p => p.ArticleId == ArticleId).First();

            editArticle.ArticleTitle = ArticleTitle;
            editArticle.ArticleLink = ArticleLink;

            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteArticle(ViewModel article)
        {

            BlogItContext db = new BlogItContext();

            Article remove = db.Articles.Where(a => a.ArticleId == article.ArticleId).First();

            remove.Visibilty = false;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}