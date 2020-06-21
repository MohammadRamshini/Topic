using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Topic.Application;
using Topic.Application.Contracts.Contracts;
using Topic.Domain.Model;
using Topic.Infrastructure.Persistence;
using Topic.Infrastructure.Persistence.Repositories;

namespace Topic.Infrastructure.Config
{
    public static class Bootstrapper
    {
        public static void Config(IServiceCollection services,string connectionString)
        {
            services.AddScoped<IArticleCategoryRepository, ArticleCategoryRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<IArticleCategoryApplication, ArticleCategoryApplication>();
            services.AddScoped<IArticleApplication, ArticleApplication>();
            services.AddDbContext<TopicContext>(builder => builder.UseSqlServer(connectionString));
        }
    }
}
