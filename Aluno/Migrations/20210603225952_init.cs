using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlunoApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeAluno = table.Column<string>(nullable: true),
                    NomePai = table.Column<string>(nullable: true),
                    NomeMae = table.Column<string>(nullable: false),
                    Sexo = table.Column<string>(nullable: true),
                    Nascimento = table.Column<string>(nullable: true),
                    RG = table.Column<int>(nullable: false),
                    CPF = table.Column<int>(nullable: false),
                    Telefone = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Turma = table.Column<string>(nullable: true),
                    Curso = table.Column<string>(nullable: true),
                    Ano = table.Column<int>(nullable: false),
                    Turno = table.Column<string>(nullable: true),
                    DataMAtricula = table.Column<DateTime>(nullable: false),
                    DataValidade = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
