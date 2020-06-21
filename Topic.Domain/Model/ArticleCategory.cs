using System;
using System.Collections.Generic;
using System.Text;

namespace Topic.Domain.Model
{
    public class ArticleCategory:SeoTags
    {
        public int ArticleCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
        public int ParentId { get; set; }
        public ArticleCategory Parent { get; set; }
        public ICollection<Article> Articles { get; set; }
        public ICollection<ArticleCategory> Children { get; set; }


        public ArticleCategory()
        {
            this.Children = new List<ArticleCategory>();
            this.Articles = new List<Article>();
        }
        public ArticleCategory(string categoryName, string description, int displayOrder, string image, int parentId,
                               string keywords, string metaDescription, string slug, string canonicalAddress) : base(keywords, metaDescription, slug, canonicalAddress)
        {
            this.CategoryName = categoryName;
            this.Description = description;
            this.DisplayOrder = displayOrder;
            this.Image = image;
            this.ParentId = parentId;
            this.IsActive = true;
        }
        public void Activate()
        {
            this.IsActive = true;
        }
        public void DeActive()
        {
            this.IsActive = false;
        }
    }
}
