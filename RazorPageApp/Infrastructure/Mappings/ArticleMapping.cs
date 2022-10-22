using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RazorPageApp.Models;

namespace RazorPageApp.Infrastructure.Mappings;

public class ArticleMapping:IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.ToTable("Articles");
        builder.HasKey("Id");
    }
}