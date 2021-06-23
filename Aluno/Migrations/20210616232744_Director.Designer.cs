﻿// <auto-generated />
using System;
using AlunoApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlunoApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210616232744_Director")]
    partial class Director
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlunoApi.Modelo.Alluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano");

                    b.Property<int>("CPF");

                    b.Property<string>("Curso");

                    b.Property<DateTime>("DataMAtricula");

                    b.Property<DateTime>("DataValidade");

                    b.Property<string>("Nascimento");

                    b.Property<string>("NomeAluno");

                    b.Property<string>("NomeMae");

                    b.Property<string>("NomePai");

                    b.Property<int>("Numero");

                    b.Property<int>("RG");

                    b.Property<string>("Rua");

                    b.Property<string>("Sexo");

                    b.Property<string>("Telefone");

                    b.Property<string>("Turma");

                    b.Property<string>("Turno");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("AlunoApi.Modelo.Coordenador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Coordenadores");
                });

            modelBuilder.Entity("AlunoApi.Modelo.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Directores");
                });

            modelBuilder.Entity("AlunoApi.Modelo.Prof", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Professores");
                });
#pragma warning restore 612, 618
        }
    }
}
