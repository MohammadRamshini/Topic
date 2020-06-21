using Microsoft.EntityFrameworkCore;
using Topic.Domain.Model;
using Topic.Infrastructure.Persistence.Mappings;

namespace Topic.Infrastructure.Persistence
{
    public class TopicContext:DbContext
    {
        DbSet<ArticleCategory> ArticleCategories { get; set; }
        DbSet<Article> Articles { get; set; }
        public TopicContext(DbContextOptions<TopicContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ArticleCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}
