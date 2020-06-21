using Framework.Application;
using System.ComponentModel.DataAnnotations;
using Topic.Domain.Model;

namespace Topic.Application.Contracts.Commands.ArticleCategory
{
    public class CreateArticleCategory:SeoTags,ICommand
    {
        [Display(Name = "عنوان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "عنوان را وارد نمایید")]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "عنوان باید بین 3 تا 70 کارکتر باشد")]
        public string CategoryName { get; set; }

        [Display(Name = "توضیحات")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "توضیحات را وارد نمایید")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "توضیحات باید بین 10 تا 200 کارکتر باشد")]
        public string Description { get; set; }

        [Display(Name = "ترتیب نمایش")]
        [Required(ErrorMessage = "ترتیب نمایش را وارد نمایید")]
        public int DisplayOrder { get; set; }

        [Display(Name = "عکس")]
        public string Image { get; set; }
        [Display(Name = "دسته مافوق")]
        public int ParentId { get; set; }
    }
}
