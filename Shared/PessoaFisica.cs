using System.ComponentModel.DataAnnotations;
using Shared;

namespace DirectBusiness.Shared
{
    public class PessoaFisica
    {
        [Key]
        public int Id {get; set;}
<<<<<<< HEAD
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
=======
>>>>>>> 8d6d1633c46882ae405cc9c4317c72d89ab8e957

        [Required(ErrorMessage = "Estado Civel é obrigatório")]
        public string EstadoCivil { get; set; }

        [Required(ErrorMessage = "RG é obrigatório")]
        public string RG { get; set; }

        [Required(ErrorMessage = "CPF é obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Data de Nascimento é obrigatório")]
        public int DataNascimento { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
<<<<<<< HEAD

=======
>>>>>>> 8d6d1633c46882ae405cc9c4317c72d89ab8e957
        public string Nome { get; set; }

        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}