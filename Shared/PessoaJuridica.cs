using System.ComponentModel.DataAnnotations;
using Shared;

namespace DirectBusiness.Shared
{
    public class PessoaJuridica
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Razão social é obrigatório")] 
        public string RazaoSocial { get; set; }
        [Required(ErrorMessage = "CNPJ é obrigatório")] 
        public string CNPJ { get; set; }

        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}