using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeCadastros.Migrations
{
    public partial class DBLunaryAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pratos",
                columns: table => new
                {
                    RESTAUID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RESTANOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RESTAPRECO = table.Column<double>(type: "float", nullable: false),
                    RESTADESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RESTACATEGORIA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RESTAPREPROMOCAO = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pratos", x => x.RESTAUID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pratos");
        }
    }
}
