using System.ComponentModel.DataAnnotations;

namespace Module06_model.CustomValidation
{
    public class AllLettersValidationAttribute:ValidationAttribute
    {
        public AllLettersValidationAttribute()
        {
            
        }

        public override bool IsValid(object? value)
        {
            return ((string)value).All(Char.IsLetter);
        }
    }
}
