using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DirectBusiness.Shared
{
    public class TipoContrato
    {
        [Key]
        public int IdTipoContrato { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório")]
        public string Descricao { get; set; }

        public List<Contrato> Contratos { get; set; }
    }
}