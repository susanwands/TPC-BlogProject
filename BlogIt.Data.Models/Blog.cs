using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogIt.Data.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public string Blogger { get; set; }

        public virtual List<Post> Posts { get; set; }

        public virtual List<Article> Articles { get; set; }
    }
}
