using System.ComponentModel.DataAnnotations;
namespace ProjetoLead.Objetos
{
    public class CreateModel
    {
        [Required]
        [ValidationAttributes.CNPJFormat]
        public string cnpj { get; set; }

        [Required]
        public string razao_social { get; set; }

        [Required]
        [ValidationAttributes.CEPFormat]
        public string cep { get; set; }

        [Required]
        public string endereco { get; set; }

        [Required]
        public int numero { get; set; }

        public string complemento { get; set; }

        [Required]
        public string bairro { get; set; }

        [Required]
        public string cidade { get; set; }

        [Required]
        public string estado { get; set; }
    }
}
