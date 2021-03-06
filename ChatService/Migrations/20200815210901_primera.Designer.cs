﻿// <auto-generated />
using System;
using ChatService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChatService.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200815210901_primera")]
    partial class primera
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Chat")
                        .HasColumnType("int");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Chat_privado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_ChatPrivado")
                        .HasColumnType("int");

                    b.Property<int>("ParticipanteA")
                        .HasColumnType("int");

                    b.Property<int>("ParticipanteB")
                        .HasColumnType("int");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Chats_privados");
                });

            modelBuilder.Entity("Mensaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChatId")
                        .HasColumnType("int");

                    b.Property<int?>("Chat_privadoId")
                        .HasColumnType("int");

                    b.Property<string>("Contenido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora_Envio")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Mensaje")
                        .HasColumnType("int");

                    b.Property<int>("ParticipanteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("Chat_privadoId");

                    b.ToTable("Mensajes");
                });

            modelBuilder.Entity("Mensaje", b =>
                {
                    b.HasOne("Chat", null)
                        .WithMany("Mensajes")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chat_privado", null)
                        .WithMany("Mensajes")
                        .HasForeignKey("Chat_privadoId");
                });
#pragma warning restore 612, 618
        }
    }
}
