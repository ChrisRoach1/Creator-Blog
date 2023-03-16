using Creator_Blog.Data.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


string ConnectionString = "Data Source=" + Directory.GetParent(Directory.GetCurrentDirectory()) + "\\app.db";

string connString = String.Format(builder.Configuration.GetConnectionString("DefaultConnection"), Directory.GetParent(Directory.GetCurrentDirectory()));
string secondString = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        @"\todo.db");

builder.Services.AddDbContext<BlogPostContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString(connString));
});


var app = builder.Build();


app.MapGet("/getBlogPosts", (BlogPostContext context) =>
{

    return context.BlogPosts.ToList();

});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();




app.Run();

