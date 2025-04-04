using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace ProjetoLead.ValidationAttributes
{
    public class CEPFormat : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var cep = (string)value;
            if (!Regex.IsMatch(cep, @"[0-9]{5}-[0-9]{3}"))
            {
                return new ValidationResult("O CEP deve estar no formato 00000-000");
            }

            return ValidationResult.Success!;

        }
    }
}
