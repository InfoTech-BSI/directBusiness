using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class Midia
    {
        public int IdMidia { get; set; }
        public int IdImovel { get; set; }
        [Required(ErrorMessage = "Link é obrigatório")] 
        public string Link { get; set; }
    }
}