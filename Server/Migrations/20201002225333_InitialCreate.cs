using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DirectBusiness.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: false),
                    Renda = table.Column<double>(nullable: false),
                    Telefone = table.Column<int>(nullable: false),
                    Endereco = table.Column<string>(nullable: false),
                    CEP = table.Column<string>(nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    Numero = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(nullable: false),
                    Complemento = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(maxLength: 2, nullable: false),
                    Login = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.IdPessoa);
                });

            migrationBuilder.CreateTable(
                name: "TipoContrato",
                columns: table => new
                {
                    IdTipoContrato = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContrato", x => x.IdTipoContrato);
                });

            migrationBuilder.CreateTable(
                name: "TipoImovel",
                columns: table => new
                {
                    IdTipoImovel = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoImovel", x => x.IdTipoImovel);
                });

            migrationBuilder.CreateTable(
                name: "PessoaFisica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPessoa = table.Column<int>(nullable: false),
                    PessoaIdPessoa = table.Column<int>(nullable: true),
                    EstadoCivil = table.Column<string>(nullable: false),
                    RG = table.Column<string>(nullable: false),
                    CPF = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaFisica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaFisica_Pessoa_PessoaIdPessoa",
                        column: x => x.PessoaIdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PessoaJuridica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPessoa = table.Column<int>(nullable: false),
                    PessoaIdPessoa = table.Column<int>(nullable: true),
                    RazaoSocial = table.Column<string>(nullable: false),
                    CNPJ = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaJuridica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaJuridica_Pessoa_PessoaIdPessoa",
                        column: x => x.PessoaIdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Imovel",
                columns: table => new
                {
                    IdImovel = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdTipoImovel = table.Column<int>(nullable: false),
                    TipoImovelIdTipoImovel = table.Column<int>(nullable: true),
                    IdPessoa = table.Column<int>(nullable: false),
                    PessoaIdPessoa = table.Column<int>(nullable: true),
                    Matricula = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Logradouro = table.Column<string>(nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Cidade = table.Column<string>(nullable: false),
                    Complemento = table.Column<string>(nullable: false),
                    UF = table.Column<string>(maxLength: 2, nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imovel", x => x.IdImovel);
                    table.ForeignKey(
                        name: "FK_Imovel_Pessoa_PessoaIdPessoa",
                        column: x => x.PessoaIdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Imovel_TipoImovel_TipoImovelIdTipoImovel",
                        column: x => x.TipoImovelIdTipoImovel,
                        principalTable: "TipoImovel",
                        principalColumn: "IdTipoImovel",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CaracteristicaImovel",
                columns: table => new
                {
                    IdCarac = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdImovel = table.Column<int>(nullable: false),
                    ImovelIdImovel = table.Column<int>(nullable: true),
                    QtdeQuartos = table.Column<int>(nullable: false),
                    QtdeBanheiros = table.Column<int>(nullable: false),
                    Estacionamento = table.Column<bool>(nullable: false),
                    Metragem = table.Column<double>(nullable: false),
                    Pets = table.Column<bool>(nullable: false),
                    Mobiliado = table.Column<bool>(nullable: false),
                    Apartamento = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaracteristicaImovel", x => x.IdCarac);
                    table.ForeignKey(
                        name: "FK_CaracteristicaImovel_Imovel_ImovelIdImovel",
                        column: x => x.ImovelIdImovel,
                        principalTable: "Imovel",
                        principalColumn: "IdImovel",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    IdContrato = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdTipoContrato = table.Column<int>(nullable: false),
                    TipoContratoIdTipoContrato = table.Column<int>(nullable: true),
                    IdImovel = table.Column<int>(nullable: false),
                    ImovelIdImovel = table.Column<int>(nullable: true),
                    IdProprietario = table.Column<int>(nullable: false),
                    PessoaIdPessoa = table.Column<int>(nullable: true),
                    IdInteressado = table.Column<int>(nullable: false),
                    Pessoa2IdPessoa = table.Column<int>(nullable: true),
                    DataInicio = table.Column<int>(nullable: false),
                    DataFim = table.Column<int>(nullable: false),
                    ValorNegociado = table.Column<double>(nullable: false),
                    Texto = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.IdContrato);
                    table.ForeignKey(
                        name: "FK_Contrato_Imovel_ImovelIdImovel",
                        column: x => x.ImovelIdImovel,
                        principalTable: "Imovel",
                        principalColumn: "IdImovel",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contrato_Pessoa_Pessoa2IdPessoa",
                        column: x => x.Pessoa2IdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contrato_Pessoa_PessoaIdPessoa",
                        column: x => x.PessoaIdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contrato_TipoContrato_TipoContratoIdTipoContrato",
                        column: x => x.TipoContratoIdTipoContrato,
                        principalTable: "TipoContrato",
                        principalColumn: "IdTipoContrato",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Midia",
                columns: table => new
                {
                    IdMidia = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdImovel = table.Column<int>(nullable: false),
                    ImovelIdImovel = table.Column<int>(nullable: true),
                    Link = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Midia", x => x.IdMidia);
                    table.ForeignKey(
                        name: "FK_Midia_Imovel_ImovelIdImovel",
                        column: x => x.ImovelIdImovel,
                        principalTable: "Imovel",
                        principalColumn: "IdImovel",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaracteristicaImovel_ImovelIdImovel",
                table: "CaracteristicaImovel",
                column: "ImovelIdImovel");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_ImovelIdImovel",
                table: "Contrato",
                column: "ImovelIdImovel");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_Pessoa2IdPessoa",
                table: "Contrato",
                column: "Pessoa2IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_PessoaIdPessoa",
                table: "Contrato",
                column: "PessoaIdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_TipoContratoIdTipoContrato",
                table: "Contrato",
                column: "TipoContratoIdTipoContrato");

            migrationBuilder.CreateIndex(
                name: "IX_Imovel_PessoaIdPessoa",
                table: "Imovel",
                column: "PessoaIdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Imovel_TipoImovelIdTipoImovel",
                table: "Imovel",
                column: "TipoImovelIdTipoImovel");

            migrationBuilder.CreateIndex(
                name: "IX_Midia_ImovelIdImovel",
                table: "Midia",
                column: "ImovelIdImovel");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaFisica_PessoaIdPessoa",
                table: "PessoaFisica",
                column: "PessoaIdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaJuridica_PessoaIdPessoa",
                table: "PessoaJuridica",
                column: "PessoaIdPessoa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaracteristicaImovel");

            migrationBuilder.DropTable(
                name: "Contrato");

            migrationBuilder.DropTable(
                name: "Midia");

            migrationBuilder.DropTable(
                name: "PessoaFisica");

            migrationBuilder.DropTable(
                name: "PessoaJuridica");

            migrationBuilder.DropTable(
                name: "TipoContrato");

            migrationBuilder.DropTable(
                name: "Imovel");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "TipoImovel");
        }
    }
}
