using System;
using System.ComponentModel.DataAnnotations;

namespace DirectBusiness.Shared
{

    public class Contrato
    {   
        [Key]

        public int IdContrato { get; set; }

        public int IdTipoContrato { get; set; }
        public TipoContrato TipoContrato { get; set; }

        public int IdImovel { get; set; }
        public Imovel Imovel { get; set; }

        public int IdProprietario { get; set; }
        public Pessoa Pessoa { get; set; }

        public int IdInteressado { get; set; }
        public Pessoa Pessoa2 { get; set; }

        [Required(ErrorMessage = "Data de Inicio é obrigatório")]
        public int DataInicio { get; set; }

        [Required(ErrorMessage = "Data de fim é obrigatório")]
        public int DataFim { get; set; }

        [Required(ErrorMessage = "Valor negociado é obrigatório")]
        public double ValorNegociado { get; set; }

        [Required(ErrorMessage = "Texto é obrigatório")]
        public string Texto { get; set; }
    }
}