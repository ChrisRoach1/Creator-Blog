using Creator_Blog.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Creator_Blog.Web.Services
{
    public interface IBlogPostService
    {

        public Task<BlogPost> CreateBlogPostAsync(BlogPost post);

    }
}
