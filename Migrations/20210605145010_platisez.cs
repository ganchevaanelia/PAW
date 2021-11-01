using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class platisez : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carduri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nume = table.Column<string>(nullable: true),
                    NrCard = table.Column<string>(nullable: true),
                    CVV = table.Column<string>(nullable: true),
                    DataExpirare = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carduri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sesizari",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Categorie = table.Column<int>(nullable: false),
                    Detalii = table.Column<string>(nullable: true),
                    NumePersoana = table.Column<string>(nullable: true),
                    dataSesizare = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sesizari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plata",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CardId = table.Column<int>(nullable: false),
                    TipPersoana = table.Column<string>(nullable: true),
                    TaxaImpozit = table.Column<int>(nullable: false),
                    Detalii = table.Column<string>(nullable: true),
                    Suma = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plata", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plata_Carduri_CardId",
                        column: x => x.CardId,
                        principalTable: "Carduri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plata_CardId",
                table: "Plata",
                column: "CardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plata");

            migrationBuilder.DropTable(
                name: "Sesizari");

            migrationBuilder.DropTable(
                name: "Carduri");
        }
    }
}
