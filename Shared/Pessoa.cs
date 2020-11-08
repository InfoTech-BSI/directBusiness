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

        [Range(1, 9999999, ErrorMessage = "Renda deve ser válida")]
        [Required(ErrorMessage = "Renda é obrigatório")]
        public double Renda { get; set; }

        [Required(ErrorMessage = "Telefone é obrigatório")]
        [StringLength(15, MinimumLength = 14, ErrorMessage = "Telefone deve ser válido")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "CEP é obrigatório")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "CEP deve ter 15 caracteres")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Endereço é obrigatório")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Bairro é obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Número é obrigatório")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatório")]
        public string Cidade { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Uf é obrigatório")]
        [MaxLength(2, ErrorMessage="UF deve conter, no máximo, 2 caracteres")]
        public string Uf { get; set; }

        [Required(ErrorMessage = "Login é obrigatório")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Login deve estar entre 6 e 50 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Senha deve estar entre 6 e 50 caracteres")]
        public string Senha { get; set; }
    }
}