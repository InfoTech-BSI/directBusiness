using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class PessoaFisica
    {
        public int Id {get; set;}
        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "Estado Civel é obrigatório")]
        public string EstadoCivil { get; set; }

        [Required(ErrorMessage = "RG é obrigatório")]
        public string RG { get; set; }

        [Required(ErrorMessage = "CPF é obrigatório")]

        public string CPF { get; set; }

        [Required(ErrorMessage = "Data de Nascimento é obrigatório")]

        public int DataNascimento { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]

        public string Nome { get; set; }
    }
}