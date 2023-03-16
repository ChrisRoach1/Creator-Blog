using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator_Blog.Data.Models
{
    public class BlogPost
    {
        public int BlogPostID { get; set; }
        public string BlogPostTitle { get; set; } = string.Empty;   

        public string BlogPostContent { get; set; } = string.Empty; 

        public DateTime BlogPostDate { get; set;}

        public string Creator { get; set; } = string.Empty;

        public Guid UserId { get;set; }
    }
}
