using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klient.Model.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Klient_Adres_AdresId",
                table: "Klient");

            migrationBuilder.DeleteData(
                table: "Klient",
                keyColumn: "Id",
                keyValue: new Guid("9f882bf5-446e-4407-90f5-cdc3dabe15f7"));

            migrationBuilder.DeleteData(
                table: "Adres",
                keyColumn: "Id",
                keyValue: new Guid("9b578c8c-8dd4-4fb7-a114-eecca9f4d5c4"));

            migrationBuilder.AlterColumn<string>(
                name: "Pesel",
                table: "Klient",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nazwisko",
                table: "Klient",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Imie",
                table: "Klient",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ulica",
                table: "Adres",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NrDomu",
                table: "Adres",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Miasto",
                table: "Adres",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Klient_Adres_AdresId",
                table: "Klient",
                column: "AdresId",
                principalTable: "Adres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Klient_Adres_AdresId",
                table: "Klient");

            migrationBuilder.AlterColumn<string>(
                name: "Pesel",
                table: "Klient",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nazwisko",
                table: "Klient",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Imie",
                table: "Klient",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Ulica",
                table: "Adres",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NrDomu",
                table: "Adres",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Miasto",
                table: "Adres",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "Adres",
                columns: new[] { "Id", "Miasto", "NrDomu", "NrMieszkania", "Ulica" },
                values: new object[] { new Guid("9b578c8c-8dd4-4fb7-a114-eecca9f4d5c4"), "Toruń", "22", "1", "Biała" });

            migrationBuilder.InsertData(
                table: "Klient",
                columns: new[] { "Id", "AdresId", "Imie", "Nazwisko", "Pesel" },
                values: new object[] { new Guid("9f882bf5-446e-4407-90f5-cdc3dabe15f7"), new Guid("9b578c8c-8dd4-4fb7-a114-eecca9f4d5c4"), "Szymek", "Kolt", "95232125123" });

            migrationBuilder.AddForeignKey(
                name: "FK_Klient_Adres_AdresId",
                table: "Klient",
                column: "AdresId",
                principalTable: "Adres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
