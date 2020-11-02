using System;
using System.ComponentModel.DataAnnotations;

namespace DirectBusiness.Shared
{

    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Renda é obrigatório")]
        public double Renda { get; set; }

        [Required(ErrorMessage = "Telefone é obrigatório")]
        public int Telefone { get; set; }

        [Required(ErrorMessage = "Endereço é obrigatório")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Bairro é obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Número é obrigatório")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Complemento é obrigatório")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Uf é obrigatório")]
        [MaxLength(2, ErrorMessage="UF deve conter, no máximo, 2 caracteres")]
        public string Uf { get; set; }

        [Required(ErrorMessage = "Login é obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        public string Senha { get; set; }

        //public Imovel Imovel { get; set; }
    }
}