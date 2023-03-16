using Creator_Blog.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Creator_Blog.Data.Contexts

{
    public class BlogPostContext : DbContext
    {
        public BlogPostContext(DbContextOptions options) : base(options) { }

        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
