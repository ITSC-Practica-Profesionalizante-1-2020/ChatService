using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatService.Migrations
{
    public partial class primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Id_Chat = table.Column<int>(nullable: false),
                    SalaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chats_privados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Id_ChatPrivado = table.Column<int>(nullable: false),
                    SalaId = table.Column<int>(nullable: false),
                    ParticipanteA = table.Column<int>(nullable: false),
                    ParticipanteB = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats_privados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mensajes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Id_Mensaje = table.Column<int>(nullable: false),
                    ChatId = table.Column<int>(nullable: false),
                    ParticipanteId = table.Column<int>(nullable: false),
                    Contenido = table.Column<string>(nullable: true),
                    Hora_Envio = table.Column<DateTime>(nullable: false),
                    Chat_privadoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensajes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mensajes_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mensajes_Chats_privados_Chat_privadoId",
                        column: x => x.Chat_privadoId,
                        principalTable: "Chats_privados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_ChatId",
                table: "Mensajes",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_Chat_privadoId",
                table: "Mensajes",
                column: "Chat_privadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mensajes");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Chats_privados");
        }
    }
}
