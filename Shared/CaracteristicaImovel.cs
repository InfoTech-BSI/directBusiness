using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DirectBusiness.Shared
{
    public class CaracteristicaImovel
    {
        [Key]
        public int IdCarac { get; set; }
        public int IdImovel { get; set; }
        public Imovel Imovel { get; set; }
        [Required(ErrorMessage = "Quantidade de quartos é obrigatório")] 
        public int QtdeQuartos { get; set; }
        [Required(ErrorMessage = "Quantidade de Banheiros é obrigatório")] 
        public int QtdeBanheiros { get; set; }
        [Required(ErrorMessage = "Estacionamento é obrigatório")] 
        public bool Estacionamento { get; set; }
        [Required(ErrorMessage = "Metragem do imóvel é obrigatório")] 
        public double Metragem { get; set; }
        [Required(ErrorMessage = "Pets é obrigatório")] 
        public bool Pets { get; set; }
        [Required(ErrorMessage = "Mobiliado é obrigatório")] 
        public bool Mobiliado { get; set; }
        [Required(ErrorMessage = "Apartamento é obrigatório")] 
        public bool Apartamento { get; set; }
    }
}