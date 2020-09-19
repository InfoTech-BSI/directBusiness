using System.ComponentModel.DataAnnotations;

namespace DirectBusiness.Shared
{
    public class Imovel
    {
        public int IdImovel { get; set; }
        [Required]
        public int IdTipoImovel { get; set; }
        public int IdPessoa { get; set; }
        public int Matricula { get; set; }
        public string Descricao { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public string UF { get; set; }
        public double Valor { get; set; }
        public string Status { get; set; }
    }
}