namespace Topic.Domain.Model
{
    public class SeoTags
    {
        public string Keywords { get; set; }
        public string MetaDescription { get; set; }
        public string Slug { get; set; }
        public string CanonicalAddress { get; set; }
        protected SeoTags()
        {
        }

        public SeoTags(string keywords, string metaDescription, string slug, string canonicalAddress)
        {
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
            CanonicalAddress = canonicalAddress;
        }
    }
}
