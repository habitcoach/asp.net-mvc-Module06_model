using Module06_model.CustomValidation;
using System.ComponentModel.DataAnnotations;

namespace Module06_model.Models
{
    public class Photo
    {
        public Photo()
        {
            
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [AllLettersValidation]
        public string Author { get; set; }
        [Required]
        [Display(Name ="Image")]
        public string ImageUrl { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
    }
}
