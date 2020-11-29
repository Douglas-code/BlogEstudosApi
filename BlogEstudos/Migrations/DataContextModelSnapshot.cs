﻿// <auto-generated />
using System;
using BlogEstudos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogEstudos.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BlogEstudos.Model.Debate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MateriaId");

                    b.ToTable("Debates");
                });

            modelBuilder.Entity("BlogEstudos.Model.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("BlogEstudos.Model.Publicacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Conteudo")
                        .HasColumnType("text");

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnType("datetime");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("text");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MateriaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Publicacoes");
                });

            modelBuilder.Entity("BlogEstudos.Model.PublicacaoDebate", b =>
                {
                    b.Property<int>("DebateId")
                        .HasColumnType("int");

                    b.Property<int>("PublicacaoId")
                        .HasColumnType("int");

                    b.HasKey("DebateId", "PublicacaoId");

                    b.HasIndex("PublicacaoId");

                    b.ToTable("PublicacoesDebates");
                });

            modelBuilder.Entity("BlogEstudos.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BlogEstudos.Model.UsuarioDebate", b =>
                {
                    b.Property<int>("DebateId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("DebateId", "UsuarioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuariosDebates");
                });

            modelBuilder.Entity("BlogEstudos.Model.UsuarioMateria", b =>
                {
                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId", "MateriaId");

                    b.HasIndex("MateriaId");

                    b.ToTable("UsuariosMaterias");
                });

            modelBuilder.Entity("BlogEstudos.Model.Debate", b =>
                {
                    b.HasOne("BlogEstudos.Model.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogEstudos.Model.Publicacao", b =>
                {
                    b.HasOne("BlogEstudos.Model.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogEstudos.Model.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogEstudos.Model.PublicacaoDebate", b =>
                {
                    b.HasOne("BlogEstudos.Model.Debate", "Debate")
                        .WithMany("PublicacoesDebates")
                        .HasForeignKey("DebateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogEstudos.Model.Publicacao", "Publicacao")
                        .WithMany("PublicacoesDebates")
                        .HasForeignKey("PublicacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogEstudos.Model.UsuarioDebate", b =>
                {
                    b.HasOne("BlogEstudos.Model.Debate", "Debate")
                        .WithMany("UsuariosDebates")
                        .HasForeignKey("DebateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogEstudos.Model.Usuario", "Usuario")
                        .WithMany("UsuarioDebates")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogEstudos.Model.UsuarioMateria", b =>
                {
                    b.HasOne("BlogEstudos.Model.Materia", "Materia")
                        .WithMany("UsuariosMaterias")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogEstudos.Model.Usuario", "Usuario")
                        .WithMany("UsuariosMaterias")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
