using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class TipoContrato
    {
        public int IdTipoContrato { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório")]
        public string Descricao { get; set; }
    }
}