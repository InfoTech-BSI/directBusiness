using System.ComponentModel.DataAnnotations;
using Shared;

namespace DirectBusiness.Shared
{
    public class PessoaJuridica
    {
        [Key]
        public int Id { get; set; }
<<<<<<< HEAD
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }

=======
        
>>>>>>> 8d6d1633c46882ae405cc9c4317c72d89ab8e957
        [Required(ErrorMessage = "Razão social é obrigatório")] 
        public string RazaoSocial { get; set; }
        [Required(ErrorMessage = "CNPJ é obrigatório")] 
        public string CNPJ { get; set; }

        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}