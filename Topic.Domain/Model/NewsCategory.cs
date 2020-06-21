using System;
using System.Collections.Generic;
using System.Text;

namespace Topic.Domain.Model
{
    public class NewsCategory:SeoTags
    {
        public int NewsCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
        public int ParentId { get; set; }
        public NewsCategory Parent { get; set; }
        public ICollection<News> News { get; set; }
        public ICollection<NewsCategory> Children { get; set; }

        public NewsCategory()
        {
            this.Children = new List<NewsCategory>();
            this.News = new List<News>();
        }
        public NewsCategory(string categoryName, string description, int displayOrder, string image, int parentId,
                               string keywords, string metaTags, string metaDescription, string slug, string canonicalAddress) : base(keywords, metaDescription, slug, canonicalAddress)
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
