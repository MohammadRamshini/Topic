using Framework.Application;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using Topic.Application.Contracts.Commands.ArticleCategory;
using Topic.Application.Contracts.Contracts;
using Topic.Application.Contracts.ViewModels;
using Topic.Domain.Model;

namespace Topic.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }
        public OperationResult Create(CreateArticleCategory command)
        {
            var result = new OperationResult("ArticleCategory", "Create");
            try
            {
                if (command == null || string.IsNullOrEmpty(command.CategoryName) || string.IsNullOrEmpty(command.Slug) || string.IsNullOrEmpty(command.Description))
                    return result.Failed(ApplicationMessages.EmptyFields);

                if (_articleCategoryRepository.IsDuplicated(x => x.CategoryName == command.CategoryName))
                    return result.Failed(ApplicationMessages.DuplicatedRecord);

                var slug = command.Slug.GenerateSlug();
                if (_articleCategoryRepository.IsDuplicated(x => x.Slug == slug))
                    return result.Failed(ApplicationMessages.DuplicatedSlug);

                var articleCategory = new ArticleCategory(command.CategoryName, command.Description, command.DisplayOrder, command.Image, command.ParentId, command.Keywords, command.MetaDescription, command.Slug, command.CanonicalAddress);
                _articleCategoryRepository.Create(articleCategory);
                _articleCategoryRepository.SavaChanges();

                return result.Succeeded(ApplicationMessages.OperationSuccess);
            }
            catch (Exception)
            {
                return result.Failed(ApplicationMessages.SystemFailure);
            }
        }

        public IEnumerable<ArticleCategoryViewModel> GetAll()
        {
            var categories = _articleCategoryRepository.GetAll();
            return MapArticleCategories(categories);
        }

        private IEnumerable<ArticleCategoryViewModel> MapArticleCategories(IEnumerable<ArticleCategory> categories)
        {
            return categories.Select(MapArticleCategory).ToList();
        }

        private ArticleCategoryViewModel MapArticleCategory(ArticleCategory articleCategory)
        {
            return new ArticleCategoryViewModel(articleCategory.CategoryName, articleCategory.Description, articleCategory.DisplayOrder, articleCategory.Image, articleCategory.IsActive, articleCategory.ParentId);
        }
    }
}
