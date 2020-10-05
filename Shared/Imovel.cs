using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
using Shared;
>>>>>>> 8d6d1633c46882ae405cc9c4317c72d89ab8e957

namespace DirectBusiness.Shared
{
    public class Imovel
    {
        [Key]
        public int IdImovel { get; set; }
<<<<<<< HEAD
        public int IdTipoImovel { get; set; }
        public TipoImovel TipoImovel { get; set; }
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }

=======
>>>>>>> 8d6d1633c46882ae405cc9c4317c72d89ab8e957
        [Required(ErrorMessage = "Matrícula é obrigatório")] 
        public int Matricula { get; set; }
        [Required(ErrorMessage = "Descrição é obrigatório")] 
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Logradouro é obrigatório")] 
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "Bairro é obrigatório")] 
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Número é obrigatório")] 
        public int Numero { get; set; }
        [Required(ErrorMessage = "Cidade é obrigatório")] 
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Complemento é obrigatório")] 
        public string Complemento { get; set; }
        [Required(ErrorMessage = "UF é obrigatório")] 
        [MaxLength(2, ErrorMessage = "UF deve conter, no máximo, 2 caracteres")]
        public string UF { get; set; }
        [Required(ErrorMessage = "Valor é obrigatório")] 
        public double Valor { get; set; }
        [Required(ErrorMessage = "Status é obrigatório")] 
        public string Status { get; set; }

        public int IdTipoImovel { get; set; }
        public TipoImovel TipoImovel { get; set; }

        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}