using Framework.Application;
using System;
using System.Collections.Generic;
using System.Text;
using Topic.Application.Contracts.Commands.ArticleCategory;
using Topic.Application.Contracts.ViewModels;

namespace Topic.Application.Contracts.Contracts
{
    public interface IArticleCategoryApplication
    {
        OperationResult Create(CreateArticleCategory command);
        IEnumerable<ArticleCategoryViewModel> GetAll();
    }
}
