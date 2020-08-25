using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatService.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Chats_ChatId",
                table: "Mensajes");

            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Chats_privados_Chat_privadoId",
                table: "Mensajes");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Chats_privados");

            migrationBuilder.DropIndex(
                name: "IX_Mensajes_ChatId",
                table: "Mensajes");

            migrationBuilder.DropIndex(
                name: "IX_Mensajes_Chat_privadoId",
                table: "Mensajes");

            migrationBuilder.DropColumn(
                name: "ChatId",
                table: "Mensajes");

            migrationBuilder.DropColumn(
                name: "Chat_privadoId",
                table: "Mensajes");

            migrationBuilder.DropColumn(
                name: "Hora_Envio",
                table: "Mensajes");

            migrationBuilder.DropColumn(
                name: "Id_Mensaje",
                table: "Mensajes");

            migrationBuilder.AddColumn<DateTime>(
                name: "Hora_Fecha_Envio",
                table: "Mensajes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Privado",
                table: "Mensajes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Mensajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Url_Archivo",
                table: "Mensajes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hora_Fecha_Envio",
                table: "Mensajes");

            migrationBuilder.DropColumn(
                name: "Privado",
                table: "Mensajes");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Mensajes");

            migrationBuilder.DropColumn(
                name: "Url_Archivo",
                table: "Mensajes");

            migrationBuilder.AddColumn<int>(
                name: "ChatId",
                table: "Mensajes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Chat_privadoId",
                table: "Mensajes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Hora_Envio",
                table: "Mensajes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Id_Mensaje",
                table: "Mensajes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Chat = table.Column<int>(type: "int", nullable: false),
                    SalaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chats_privados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_ChatPrivado = table.Column<int>(type: "int", nullable: false),
                    ParticipanteA = table.Column<int>(type: "int", nullable: false),
                    ParticipanteB = table.Column<int>(type: "int", nullable: false),
                    SalaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats_privados", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_ChatId",
                table: "Mensajes",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_Chat_privadoId",
                table: "Mensajes",
                column: "Chat_privadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Chats_ChatId",
                table: "Mensajes",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Chats_privados_Chat_privadoId",
                table: "Mensajes",
                column: "Chat_privadoId",
                principalTable: "Chats_privados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
