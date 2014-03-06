using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogIt.Data.Models
{
    public class Article
    {
        public int ArticleId { get; set; }

        public string ArticleTitle { get; set; }
        public string ArticleLink { get; set; }

        public bool Visibilty { get; set; }

        public int BlogId { get; set;}
        public virtual Blog Blog { get; set; }


    }
}
