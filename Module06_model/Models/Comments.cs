using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Module06_model.CustomValidation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module06_model.Models
{
    public class Comments
    {
        public Comments()
        {
            
        }

        [Key]
        public int Id { get; set; }

        public string Comment { get; set; }

        public DateTime CreatedDate { get; set; }
        [AllLettersValidation]
        public string UserName { get; set; }

       
        public int PhotoId { get; set; }

        //Relationship
        [ForeignKey("PhotoId")]
        [ValidateNever]
        public  Photo Photo { get; set; }

    }
}
