namespace BlogIt.Data.Migrations
{
    using BlogIt.Data.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    

    internal sealed class Configuration : DbMigrationsConfiguration<BlogIt.Data.BlogItContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogIt.Data.BlogItContext context)
        {


            //context.Blogs.AddOrUpdate(
            //  b => b.BlogName,
            //  new Blog { BlogName = "Code Pink", Blogger = "The Pink Coder" }
            //);

            context.Posts.AddOrUpdate(
                c => c.PostId,

                new Post { Visibilty = true, Title = "A blog post jdhfjd skdjfhf", DatePosted = DateTime.Today, BlogId = 1, Content = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros " },
                new Post { Visibilty = true, Title = "A legunt saepius. Claritas esdhfjd skdjfhf", DatePosted = DateTime.Today, BlogId = 1, Content = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros " },
                new Post { Visibilty = true, Title = "A blog poslegunt saepius. Claritas esjd skdjfhf", DatePosted = DateTime.Today, BlogId = 1, Content = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros " },
                new Post { Visibilty = true, Title = "Alegunt saepius. Claritas es", DatePosted = DateTime.Today, BlogId = 1, Content = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros " },
                new Post { Visibilty = true, Title = "A bllegunt saepius. Claritas esskdjfhf", DatePosted = DateTime.Today, BlogId = 1, Content = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros " },
                new Post { Visibilty = true, Title = "A blog legunt saepius. Claritas eshf", DatePosted = DateTime.Today, BlogId = 1, Content = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros " },
                new Post { Visibilty = true, Title = "A legunt saepius. Claritas esd skdjfhf", DatePosted = DateTime.Today, BlogId = 1, Content = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros " },
                new Post { Visibilty = true, Title = "A legunt saepius. Claritas esf", DatePosted = DateTime.Today, BlogId = 1, Content = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros " },
                new Post { Visibilty = true, Title = "legunt saepius. Claritas esjdhfjd skdjfhf", DatePosted = DateTime.Today, BlogId = 1, Content = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros " },
                new Post { Visibilty = true, Title = "legunt saepius. Claritas esdjfhf", DatePosted = DateTime.Today, BlogId = 1, Content = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros " },
                new Post { Visibilty = true, Title = "legunt saepius. Claritas esjdhfjd skdjfhf", DatePosted = DateTime.Today, BlogId = 1, Content = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros " },
                new Post { Visibilty = true, Title = "A bllegunt saepius. Claritas es skdjfhf", DatePosted = DateTime.Today, BlogId = 1, Content = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros " },
                new Post { Visibilty = true, Title = "A legunt saepius. Claritas eshf", DatePosted = DateTime.Today, BlogId = 1, Content = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros " },
                new Post { Visibilty = true, Title = "A blog legunt saepius. Claritas eskdjfhf", DatePosted = DateTime.Today, BlogId = 1, Content = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros " },
                new Post { Visibilty = true, Title = "A blegunt saepius. Claritas eskdjfhf", DatePosted = DateTime.Today, BlogId = 1, Content = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros " }
            );



            context.Articles.AddOrUpdate(
                a => a.ArticleId,

                new Article { BlogId=1, Visibilty = true, ArticleTitle = "Flappy Bird Creator Dong Nguyen Says App 'Gone Forever", ArticleLink = "http://www.forbes.com/sites/lananhnguyen/2014/02/11/exclusive-flappy-bird-creator-dong-nguyen-says-app-gone-forever-because-it-was-an-addictive-product/" },
                new Article { BlogId = 1, Visibilty = true, ArticleTitle = "Facebook’s Sandberg And Ebersman Say They’re Not Planning To Flood The News Feed With Ads", ArticleLink = "http://techcrunch.com/2014/02/11/facebook-goldman-sachs-ads/" },
                new Article { BlogId = 1, Visibilty = true, ArticleTitle = "Mileways, The Social App For Frequent Flyers", ArticleLink = "http://techcrunch.com/2014/02/05/mileways/" },
                new Article { BlogId = 1, Visibilty = true, ArticleTitle = "Defense Contractors Shore Up Security Post-Snowden", ArticleLink = "http://www.technewsworld.com/story/Defense-Contractors-Shore-Up-Security-Post-Snowden-79951.html" },
                new Article { BlogId = 1, Visibilty = true, ArticleTitle = "'Beep' works like a Chromecast for your old speakers", ArticleLink = "http://www.engadget.com/2014/02/06/beep/" },
                new Article { BlogId = 1, Visibilty = true, ArticleTitle = "How a Math Genius Hacked OkCupid to Find True Love", ArticleLink = "http://www.wired.com/wiredscience/2014/01/how-to-hack-okcupid/" },
                new Article { BlogId = 1, Visibilty = true, ArticleTitle = "10 Years Ago Today, Dave Chappelle and Rick James Changed the World", ArticleLink = "http://www.wired.com/underwire/2014/02/chappelle-rick-james/" },
                new Article { BlogId = 1, Visibilty = true, ArticleTitle = "The Strange, Deadly Effects Mars Would Have on Your Body", ArticleLink = "http://www.wired.com/opinion/2014/02/happens-body-mars/" },
                new Article { BlogId = 1, Visibilty = true, ArticleTitle = "How Steve Jobs Made the iPad Succeed When All Other Tablets Failed", ArticleLink = "http://www.wired.com/opinion/2013/11/one-ipad-to-rule-them-all-all-those-who-dream-big-are-not-lost/" },
                new Article { BlogId = 1, Visibilty = true, ArticleTitle = "A Web-Connected Gadget That Pours Perfect Cocktails, From the Makers of Absolut", ArticleLink = "http://www.wired.com/design/2014/02/meet-bar-future/" },
                new Article { BlogId = 1, Visibilty = true, ArticleTitle = "How Home Depot Copied Apple to Build an Ingenious New Bucket", ArticleLink = "http://www.wired.com/design/2013/12/home-depot-reinvents-buckets/" },
                new Article { BlogId = 1, Visibilty = true, ArticleTitle = "So, Turns Out Crocodiles Can Climb Trees", ArticleLink = "http://www.wired.com/wiredscience/2014/02/crocodiles-can-climb-trees/" }

            );
        }
    }
}
