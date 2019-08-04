using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klient.Model.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Ulica = table.Column<string>(nullable: true),
                    Miasto = table.Column<string>(nullable: true),
                    NrDomu = table.Column<string>(nullable: true),
                    NrMieszkania = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Klient",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Pesel = table.Column<string>(nullable: true),
                    Imie = table.Column<string>(nullable: true),
                    Nazwisko = table.Column<string>(nullable: true),
                    AdresId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Klient_Adres_AdresId",
                        column: x => x.AdresId,
                        principalTable: "Adres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Adres",
                columns: new[] { "Id", "Miasto", "NrDomu", "NrMieszkania", "Ulica" },
                values: new object[] { new Guid("9b578c8c-8dd4-4fb7-a114-eecca9f4d5c4"), "Toruń", "22", "1", "Biała" });

            migrationBuilder.InsertData(
                table: "Klient",
                columns: new[] { "Id", "AdresId", "Imie", "Nazwisko", "Pesel" },
                values: new object[] { new Guid("9f882bf5-446e-4407-90f5-cdc3dabe15f7"), new Guid("9b578c8c-8dd4-4fb7-a114-eecca9f4d5c4"), "Szymek", "Kolt", "95232125123" });

            migrationBuilder.CreateIndex(
                name: "IX_Klient_AdresId",
                table: "Klient",
                column: "AdresId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Klient");

            migrationBuilder.DropTable(
                name: "Adres");
        }
    }
}
