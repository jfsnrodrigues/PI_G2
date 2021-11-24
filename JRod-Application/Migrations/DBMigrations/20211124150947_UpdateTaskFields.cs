using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JRod_Application.Migrations.DBMigrations
{
    public partial class UpdateTaskFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Assunto",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Camara",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreaspReg",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataFim",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicio",
                table: "Tasks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interessado",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Protocolo",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProvidenciasAdotadas",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoAtividade",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoServico",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoTrabalho",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Assunto",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Camara",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "CreaspReg",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Interessado",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Protocolo",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ProvidenciasAdotadas",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TipoAtividade",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TipoServico",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TipoTrabalho",
                table: "Tasks");
        }
    }
}
