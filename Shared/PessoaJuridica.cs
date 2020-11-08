using System.ComponentModel.DataAnnotations;

namespace DirectBusiness.Shared
{
    public class PessoaJuridica
    {
        [Key]
        public int Id { get; set; }
        
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }

        [Required(ErrorMessage = "Razão social é obrigatório")] 
        public string RazaoSocial { get; set; }
        [Required(ErrorMessage = "CNPJ é obrigatório")] 
        public string CNPJ { get; set; }
    }
}