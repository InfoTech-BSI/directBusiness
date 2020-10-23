using System.ComponentModel.DataAnnotations;

namespace DirectBusiness.Shared
{
    public class Midia
    {
        [Key]
        public int IdMidia { get; set; }
        public int IdImovel { get; set; }
        public Imovel Imovel { get; set; }
        [Required(ErrorMessage = "Link é obrigatório")] 
        public string Link { get; set; }
    }
}