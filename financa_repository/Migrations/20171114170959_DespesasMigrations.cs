using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace financa_repository.Migrations
{
    public partial class DespesasMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposDespesas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDespesas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Despesas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dataDespesa = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    estabelecimento = table.Column<string>(type: "longtext", nullable: true),
                    grupoDespesaid = table.Column<int>(type: "int", nullable: true),
                    numDoc = table.Column<string>(type: "longtext", nullable: true),
                    valor = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despesas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Despesas_TiposDespesas_grupoDespesaid",
                        column: x => x.grupoDespesaid,
                        principalTable: "TiposDespesas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Despesas_grupoDespesaid",
                table: "Despesas",
                column: "grupoDespesaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Despesas");

            migrationBuilder.DropTable(
                name: "TiposDespesas");
        }
    }
}
