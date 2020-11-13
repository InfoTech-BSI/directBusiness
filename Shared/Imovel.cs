using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace DirectBusiness.Shared
{
    public class Imovel
    {
        [Key]
        public int IdImovel { get; set; }

        public int IdTipoImovel { get; set; }
        public TipoImovel TipoImovel { get; set; }
        
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }

        [Required(ErrorMessage = "Matrícula é obrigatório")] 
        public int Matricula { get; set; }
        [Required(ErrorMessage = "Descrição é obrigatório")] 
        public string Descricao { get; set; }
        [Required(ErrorMessage = "CEP é obrigatório")] 
        public string CEP { get; set; }
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

        //public Contrato Contrato { get; set; }
        public List<Midia> Midias { get; set; }
        //public CaracteristicaImovel CaracteristicaImovel { get; set; }
    }
}