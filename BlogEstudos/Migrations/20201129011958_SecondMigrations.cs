using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogEstudos.Migrations
{
    public partial class SecondMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MateriaId",
                table: "Debates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PublicacoesDebates",
                columns: table => new
                {
                    PublicacaoId = table.Column<int>(nullable: false),
                    DebateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicacoesDebates", x => new { x.DebateId, x.PublicacaoId });
                    table.ForeignKey(
                        name: "FK_PublicacoesDebates_Debates_DebateId",
                        column: x => x.DebateId,
                        principalTable: "Debates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublicacoesDebates_Publicacoes_PublicacaoId",
                        column: x => x.PublicacaoId,
                        principalTable: "Publicacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Debates_MateriaId",
                table: "Debates",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicacoesDebates_PublicacaoId",
                table: "PublicacoesDebates",
                column: "PublicacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Debates_Materias_MateriaId",
                table: "Debates",
                column: "MateriaId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Debates_Materias_MateriaId",
                table: "Debates");

            migrationBuilder.DropTable(
                name: "PublicacoesDebates");

            migrationBuilder.DropIndex(
                name: "IX_Debates_MateriaId",
                table: "Debates");

            migrationBuilder.DropColumn(
                name: "MateriaId",
                table: "Debates");
        }
    }
}
