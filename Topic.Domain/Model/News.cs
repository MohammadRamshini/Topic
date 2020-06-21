using System;
using System.Collections.Generic;
using System.Text;

namespace Topic.Domain.Model
{
    public class News: SeoTags
    {
        public long NewsId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Summary { get; set; }
        public string NewsDate { get; set; }
        public string NewsTime { get; set; }
        public int VisitCount { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }

        public News(string title, string content, string summary, string creationDate, string newsTime, string image,
                    string keywords, string metaTags, string metaDescription, string slug, string canonicalAddress) : base(keywords, metaDescription, slug, canonicalAddress)
        {
            this.Title = title;
            this.Content = content;
            this.Summary = summary;
            this.NewsDate = creationDate;
            this.NewsTime = newsTime;
            this.Image = image;
            this.IsActive = true;
        }

        public void IsActivate()
        {
            this.IsActive = true;
        }
        public void DeActive()
        {
            this.IsActive = false;
        }
    }
}
