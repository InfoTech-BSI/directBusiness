using Microsoft.EntityFrameworkCore.Migrations;

namespace DirectBusiness.Server.Migrations
{
    public partial class desenvolvimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apartamento",
                table: "CaracteristicaImovel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Apartamento",
                table: "CaracteristicaImovel",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
