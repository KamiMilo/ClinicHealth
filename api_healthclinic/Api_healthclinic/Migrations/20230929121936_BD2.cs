using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_healthclinic.Migrations
{
    /// <inheritdoc />
    public partial class BD2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrador");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Paciente");

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Paciente",
                type: "VARCHAR(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Crm",
                table: "Medico",
                type: "VARCHAR(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_Cpf",
                table: "Paciente",
                column: "Cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_Telefone",
                table: "Paciente",
                column: "Telefone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Especialidade_EspecialidadeNome",
                table: "Especialidade",
                column: "EspecialidadeNome",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Paciente_Cpf",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_Telefone",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Especialidade_EspecialidadeNome",
                table: "Especialidade");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Paciente");

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "Paciente",
                type: "VARCHAR(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Crm",
                table: "Medico",
                type: "VARCHAR(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(10)",
                oldMaxLength: 10);

            migrationBuilder.CreateTable(
                name: "Administrador",
                columns: table => new
                {
                    IdAdministrador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrador", x => x.IdAdministrador);
                    table.ForeignKey(
                        name: "FK_Administrador_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administrador_IdUsuario",
                table: "Administrador",
                column: "IdUsuario");
        }
    }
}
