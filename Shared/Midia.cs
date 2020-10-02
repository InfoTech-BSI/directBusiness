using System.ComponentModel.DataAnnotations;

namespace DirectBusiness.Shared
{
    public class Midia
    {
        public int IdMidia { get; set; }
        public int IdImovel { get; set; }
        [Required(ErrorMessage = "Link é obrigatório")] 
        public string Link { get; set; }
    }
}