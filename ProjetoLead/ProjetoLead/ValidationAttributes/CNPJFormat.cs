using CpfCnpjLibrary;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace ProjetoLead.ValidationAttributes
{
    public class CNPJFormat : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var cnpj = (string)value;
            if (!Regex.IsMatch(cnpj, @"[0-9]{2}\.[0-9]{3}\.[0-9]{3}\/[0-9]{4}-[0-9]{2}$"))
            {
                return new ValidationResult("O CNPJ deve estar no formato 00.000.000/0000-00");
            }
            else if(!Cnpj.Validar(cnpj))
            {
                return new ValidationResult("O CNPJ é Invalido");
            }
            return ValidationResult.Success!;
        }
    }
}
