using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class TipoImovel
    {
        public int IdTipoImovel { get; set; }
        [Required(ErrorMessage = "Descrição é obrigatório")] 
        public string Descricao { get; set; }
    }
}