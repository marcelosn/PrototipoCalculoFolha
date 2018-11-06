using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SimuladoreSocial.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CodigoPagamento",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodigoPagamento", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CodigoTerceiros",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodigoTerceiros", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FPAS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FPAS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TCnae",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoCNAE = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    FPAS = table.Column<int>(nullable: false),
                    RAT = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCnae", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TEmpresas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AliquotaFAP = table.Column<double>(nullable: false),
                    CnaeID = table.Column<int>(nullable: true),
                    CodigoFpasID = table.Column<int>(nullable: true),
                    CodigoPagamentoID = table.Column<int>(nullable: true),
                    CodigoTerceirosID = table.Column<int>(nullable: true),
                    DataAbertura = table.Column<string>(nullable: true),
                    ESocial = table.Column<int>(nullable: false),
                    EmpresaMatriz = table.Column<bool>(nullable: false),
                    FPASPercentual = table.Column<double>(nullable: false),
                    Inscricao = table.Column<string>(nullable: true),
                    NaturezaJuridica = table.Column<string>(nullable: true),
                    NomeFantasia = table.Column<string>(nullable: true),
                    OptanteSimplesNacional = table.Column<bool>(nullable: false),
                    PagaPercetualEmpregadores = table.Column<bool>(nullable: false),
                    Porte = table.Column<int>(nullable: false),
                    RAT = table.Column<double>(nullable: false),
                    RazaoSocial = table.Column<string>(nullable: true),
                    Situacao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEmpresas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TEmpresas_TCnae_CnaeID",
                        column: x => x.CnaeID,
                        principalTable: "TCnae",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TEmpresas_FPAS_CodigoFpasID",
                        column: x => x.CodigoFpasID,
                        principalTable: "FPAS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TEmpresas_CodigoPagamento_CodigoPagamentoID",
                        column: x => x.CodigoPagamentoID,
                        principalTable: "CodigoPagamento",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TEmpresas_CodigoTerceiros_CodigoTerceirosID",
                        column: x => x.CodigoTerceirosID,
                        principalTable: "CodigoTerceiros",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TEmpresas_CnaeID",
                table: "TEmpresas",
                column: "CnaeID");

            migrationBuilder.CreateIndex(
                name: "IX_TEmpresas_CodigoFpasID",
                table: "TEmpresas",
                column: "CodigoFpasID");

            migrationBuilder.CreateIndex(
                name: "IX_TEmpresas_CodigoPagamentoID",
                table: "TEmpresas",
                column: "CodigoPagamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_TEmpresas_CodigoTerceirosID",
                table: "TEmpresas",
                column: "CodigoTerceirosID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TEmpresas");

            migrationBuilder.DropTable(
                name: "TCnae");

            migrationBuilder.DropTable(
                name: "FPAS");

            migrationBuilder.DropTable(
                name: "CodigoPagamento");

            migrationBuilder.DropTable(
                name: "CodigoTerceiros");
        }
    }
}
