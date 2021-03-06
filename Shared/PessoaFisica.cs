using System;
using System.ComponentModel.DataAnnotations;

namespace DirectBusiness.Shared
{
    public class PessoaFisica
    {
        [Key]
        public int Id {get; set;}

        [ValidateComplexType]
        public Pessoa Pessoa { get; set; } = new Pessoa();

        [Required(ErrorMessage = "Estado Civil é obrigatório")]
        public string EstadoCivil { get; set; }

        [Required(ErrorMessage = "RG é obrigatório")]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "O RG deve ter 12 caracteres.")]
        public string RG { get; set; }

        [Required(ErrorMessage = "CPF é obrigatório")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "O CPF deve ter 15 caracteres.")]
        public string CPF { get; set; }

        [Range(typeof(DateTime), "01/01/1900", "31/12/2020", ErrorMessage = "Data de Nascimento deve estar entre 01/01/1900 e 31/12/2020")]
        [Required(ErrorMessage = "Data de Nascimento é obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }
    }
}