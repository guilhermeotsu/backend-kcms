using System.ComponentModel.DataAnnotations;

namespace KCMS.ViewModel
{
    public class CategoryViewModel
    {
        [Required(ErrorMessage = "The field Name is required!")]
        [MaxLength(50, ErrorMessage = "The field Name has MaxLength 50!")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "The field Description is required!")]
        [MaxLength(50, ErrorMessage = "The field Description has MaxLength 50!")]
        public string Description { get; set; }
    }
}
