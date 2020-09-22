using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class PessoaJuridica
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        [Required(ErrorMessage = "Razão social é obrigatório")] 
        public string RazaoSocial { get; set; }
        [Required(ErrorMessage = "CNPJ é obrigatório")] 
        public string CNPJ { get; set; }
    }
}