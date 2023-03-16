using Creator_Blog.Data.Models;

namespace Creator_Blog.Web.Services
{
    public class BlogPostService : IBlogPostService
    {
        public Task<BlogPost> CreateBlogPostAsync(BlogPost post)
        {
            post.BlogPostDate = DateTime.Now;
            post.Creator = "Chris Roach";

            return Task.FromResult(post);   
        }
    }
}
