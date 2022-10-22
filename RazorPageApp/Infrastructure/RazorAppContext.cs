using Microsoft.EntityFrameworkCore;
using RazorPageApp.Infrastructure.Mappings;
using RazorPageApp.Models;

namespace RazorPageApp.Infrastructure;

public class RazorAppContext: DbContext
{
    public DbSet<Article> Articles { get; set; }

    public RazorAppContext(DbContextOptions<RazorAppContext> options):base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ArticleMapping());
        base.OnModelCreating(modelBuilder);
    }
}