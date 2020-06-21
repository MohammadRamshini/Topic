using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Topic.Domain.Model;

namespace Topic.Infrastructure.Persistence.Mappings
{
    public class ArticleCategoryMapping : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.ToTable("ArticleCategories");
            builder.HasKey(x => x.ArticleCategoryId);
            builder.HasOne(x => x.Parent).WithMany(x => x.Children).HasForeignKey(x => x.ParentId)
                .OnDelete(DeleteBehavior.ClientCascade);
            builder.HasMany(x => x.Articles).WithOne(x => x.ArticleCategory).HasForeignKey(x => x.ArticleCategoryId);
        }
    }
}
