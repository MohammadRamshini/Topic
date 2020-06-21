namespace Topic.Application.Contracts.ViewModels
{
    public class ArticleCategoryViewModel
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
        public int ParentId { get; set; }

        public ArticleCategoryViewModel(string categoryName, string description, int displayOrder, string image, bool isActive, int parentId)
        {
            CategoryName = categoryName;
            Description = description;
            DisplayOrder = displayOrder;
            Image = image;
            IsActive = isActive;
            ParentId = parentId;
        }
    }
}
