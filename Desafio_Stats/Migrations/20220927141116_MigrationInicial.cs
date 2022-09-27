using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Desafio_Stats.Migrations
{
    public partial class MigrationInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ocorrenciaEnvolvidos",
                columns: table => new
                {
                    OcorrenciaEnvolvidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Condicao = table.Column<byte>(type: "tinyint", nullable: false),
                    UsoAlgemas = table.Column<bool>(type: "bit", nullable: false),
                    MotivoAlgema = table.Column<int>(type: "int", nullable: true),
                    OutroMotivoAlgema = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NomeCompleto = table.Column<string>(type: "nvarchar(280)", maxLength: 280, nullable: true),
                    RG = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Expeditor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UFEMissor = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    NomeMae = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    NomePai = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    Nacionalidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Naturalidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Genero = table.Column<byte>(type: "tinyint", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    Logradouro = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EnderecoNumero = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    Profissao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Empresa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TelefoneFixo = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    TelefoneCelular = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ocorrenciaEnvolvidos", x => x.OcorrenciaEnvolvidoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ocorrenciaEnvolvidos");
        }
    }
}
