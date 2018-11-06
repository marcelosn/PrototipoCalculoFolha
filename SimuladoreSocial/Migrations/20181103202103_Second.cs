using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SimuladoreSocial.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TEmpresas_FPAS_CodigoFpasID",
                table: "TEmpresas");

            migrationBuilder.DropForeignKey(
                name: "FK_TEmpresas_CodigoPagamento_CodigoPagamentoID",
                table: "TEmpresas");

            migrationBuilder.DropForeignKey(
                name: "FK_TEmpresas_CodigoTerceiros_CodigoTerceirosID",
                table: "TEmpresas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FPAS",
                table: "FPAS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CodigoTerceiros",
                table: "CodigoTerceiros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CodigoPagamento",
                table: "CodigoPagamento");

            migrationBuilder.RenameTable(
                name: "FPAS",
                newName: "TCodigoFPAS");

            migrationBuilder.RenameTable(
                name: "CodigoTerceiros",
                newName: "TCodigoTerceiros");

            migrationBuilder.RenameTable(
                name: "CodigoPagamento",
                newName: "TCodigoPagamento");

            migrationBuilder.AddColumn<int>(
                name: "ClassificacaoID",
                table: "TEmpresas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LotacaoID",
                table: "TEmpresas",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TCodigoFPAS",
                table: "TCodigoFPAS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TCodigoTerceiros",
                table: "TCodigoTerceiros",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TCodigoPagamento",
                table: "TCodigoPagamento",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "TClassificacao",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TClassificacao", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TCodigoLotacao",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCodigoLotacao", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TEmpresas_ClassificacaoID",
                table: "TEmpresas",
                column: "ClassificacaoID");

            migrationBuilder.CreateIndex(
                name: "IX_TEmpresas_LotacaoID",
                table: "TEmpresas",
                column: "LotacaoID");

            migrationBuilder.AddForeignKey(
                name: "FK_TEmpresas_TClassificacao_ClassificacaoID",
                table: "TEmpresas",
                column: "ClassificacaoID",
                principalTable: "TClassificacao",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TEmpresas_TCodigoFPAS_CodigoFpasID",
                table: "TEmpresas",
                column: "CodigoFpasID",
                principalTable: "TCodigoFPAS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TEmpresas_TCodigoPagamento_CodigoPagamentoID",
                table: "TEmpresas",
                column: "CodigoPagamentoID",
                principalTable: "TCodigoPagamento",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TEmpresas_TCodigoTerceiros_CodigoTerceirosID",
                table: "TEmpresas",
                column: "CodigoTerceirosID",
                principalTable: "TCodigoTerceiros",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TEmpresas_TCodigoLotacao_LotacaoID",
                table: "TEmpresas",
                column: "LotacaoID",
                principalTable: "TCodigoLotacao",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TEmpresas_TClassificacao_ClassificacaoID",
                table: "TEmpresas");

            migrationBuilder.DropForeignKey(
                name: "FK_TEmpresas_TCodigoFPAS_CodigoFpasID",
                table: "TEmpresas");

            migrationBuilder.DropForeignKey(
                name: "FK_TEmpresas_TCodigoPagamento_CodigoPagamentoID",
                table: "TEmpresas");

            migrationBuilder.DropForeignKey(
                name: "FK_TEmpresas_TCodigoTerceiros_CodigoTerceirosID",
                table: "TEmpresas");

            migrationBuilder.DropForeignKey(
                name: "FK_TEmpresas_TCodigoLotacao_LotacaoID",
                table: "TEmpresas");

            migrationBuilder.DropTable(
                name: "TClassificacao");

            migrationBuilder.DropTable(
                name: "TCodigoLotacao");

            migrationBuilder.DropIndex(
                name: "IX_TEmpresas_ClassificacaoID",
                table: "TEmpresas");

            migrationBuilder.DropIndex(
                name: "IX_TEmpresas_LotacaoID",
                table: "TEmpresas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TCodigoTerceiros",
                table: "TCodigoTerceiros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TCodigoPagamento",
                table: "TCodigoPagamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TCodigoFPAS",
                table: "TCodigoFPAS");

            migrationBuilder.DropColumn(
                name: "ClassificacaoID",
                table: "TEmpresas");

            migrationBuilder.DropColumn(
                name: "LotacaoID",
                table: "TEmpresas");

            migrationBuilder.RenameTable(
                name: "TCodigoTerceiros",
                newName: "CodigoTerceiros");

            migrationBuilder.RenameTable(
                name: "TCodigoPagamento",
                newName: "CodigoPagamento");

            migrationBuilder.RenameTable(
                name: "TCodigoFPAS",
                newName: "FPAS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CodigoTerceiros",
                table: "CodigoTerceiros",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CodigoPagamento",
                table: "CodigoPagamento",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FPAS",
                table: "FPAS",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TEmpresas_FPAS_CodigoFpasID",
                table: "TEmpresas",
                column: "CodigoFpasID",
                principalTable: "FPAS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TEmpresas_CodigoPagamento_CodigoPagamentoID",
                table: "TEmpresas",
                column: "CodigoPagamentoID",
                principalTable: "CodigoPagamento",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TEmpresas_CodigoTerceiros_CodigoTerceirosID",
                table: "TEmpresas",
                column: "CodigoTerceirosID",
                principalTable: "CodigoTerceiros",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
