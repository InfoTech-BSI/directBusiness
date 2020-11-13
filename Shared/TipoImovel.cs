using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DirectBusiness.Shared
{
    public class TipoImovel
    {
        [Key]
        public int IdTipoImovel { get; set; }
        [Required(ErrorMessage = "Descrição é obrigatório")] 
        public string Descricao { get; set; }

        public ICollection<Imovel> Imoveis { get; set; }
    }
}