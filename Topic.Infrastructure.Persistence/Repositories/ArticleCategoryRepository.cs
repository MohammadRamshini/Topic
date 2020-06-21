using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Topic.Domain.Model;

namespace Topic.Infrastructure.Persistence.Repositories
{
    public class ArticleCategoryRepository : BaseRepository<int, ArticleCategory>, IArticleCategoryRepository
    {
        public ArticleCategoryRepository(TopicContext context) : base(context)
        {
        }
    }
}
