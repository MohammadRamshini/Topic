using System;
using System.Collections.Generic;
using System.Text;

namespace Topic.Domain.Model
{
    public class Article:SeoTags
    {
        public int ArticleId { get; set; }
        public int ArticleCategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string CreationDate { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
        public ArticleCategory ArticleCategory { get; set; }


        public Article(string title, string description, string content, string image, string creationDate, int displayOrder,
                       string keywords, string metaDescription, string slug, string canonicalAddress) : base(keywords, metaDescription, slug, canonicalAddress)
        {
            this.Title = title;
            this.Description = description;
            this.Content = content;
            this.Image = image;
            this.CreationDate = creationDate;
            this.DisplayOrder = displayOrder;
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
