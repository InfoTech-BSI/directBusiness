namespace BlazorValidation.Data
{
    using DirectBusiness.Shared;
    using System.ComponentModel.DataAnnotations;
    public class ComplexModel
    {
        [ValidateComplexType]
        public Pessoa pessoa { get; set; }

        [ValidateComplexType]
        public PessoaFisica pessoaFisica { get; set; }
    }
}
