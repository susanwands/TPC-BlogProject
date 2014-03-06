using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogIt.Data.Models
{
    public class Post
    {
        public int PostId { get; set; }

        public string Title { get; set; }
        public DateTime DatePosted { get; set; }
        public string Content { get; set; }

        public bool Visibilty { get; set; }

        public int BlogId { get; set;}
        public virtual Blog Blog { get; set; }



    }
}
