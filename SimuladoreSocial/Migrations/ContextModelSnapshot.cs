﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SimuladoreSocial.Models;
using SimuladoreSocial.Models.Empresas;
using System;

namespace SimuladoreSocial.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SimuladoreSocial.Models.Empresas.Empresas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AliquotaFAP");

                    b.Property<int?>("ClassificacaoID");

                    b.Property<int?>("CnaeID");

                    b.Property<int?>("CodigoFpasID");

                    b.Property<int?>("CodigoPagamentoID");

                    b.Property<int?>("CodigoTerceirosID");

                    b.Property<string>("DataAbertura");

                    b.Property<int>("ESocial");

                    b.Property<bool>("EmpresaMatriz");

                    b.Property<double>("FPASPercentual");

                    b.Property<string>("Inscricao");

                    b.Property<int?>("LotacaoID");

                    b.Property<string>("NaturezaJuridica");

                    b.Property<string>("NomeFantasia");

                    b.Property<bool>("OptanteSimplesNacional");

                    b.Property<bool>("PagaPercetualEmpregadores");

                    b.Property<int>("Porte");

                    b.Property<double>("RAT");

                    b.Property<string>("RazaoSocial");

                    b.Property<int>("Situacao");

                    b.HasKey("ID");

                    b.HasIndex("ClassificacaoID");

                    b.HasIndex("CnaeID");

                    b.HasIndex("CodigoFpasID");

                    b.HasIndex("CodigoPagamentoID");

                    b.HasIndex("CodigoTerceirosID");

                    b.HasIndex("LotacaoID");

                    b.ToTable("TEmpresas");
                });

            modelBuilder.Entity("SimuladoreSocial.Models.Governo.ClassificacaoTributaria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("TClassificacao");
                });

            modelBuilder.Entity("SimuladoreSocial.Models.Governo.CNAE", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodigoCNAE");

                    b.Property<string>("Descricao");

                    b.Property<int>("FPAS");

                    b.Property<double>("RAT");

                    b.HasKey("ID");

                    b.ToTable("TCnae");
                });

            modelBuilder.Entity("SimuladoreSocial.Models.Governo.CodigoPagamento", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("TCodigoPagamento");
                });

            modelBuilder.Entity("SimuladoreSocial.Models.Governo.CodigoTerceiros", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("TCodigoTerceiros");
                });

            modelBuilder.Entity("SimuladoreSocial.Models.Governo.FPAS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("TCodigoFPAS");
                });

            modelBuilder.Entity("SimuladoreSocial.Models.Governo.LotacaoTributaria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("TCodigoLotacao");
                });

            modelBuilder.Entity("SimuladoreSocial.Models.Empresas.Empresas", b =>
                {
                    b.HasOne("SimuladoreSocial.Models.Governo.ClassificacaoTributaria", "Classificacao")
                        .WithMany()
                        .HasForeignKey("ClassificacaoID");

                    b.HasOne("SimuladoreSocial.Models.Governo.CNAE", "CNAE")
                        .WithMany()
                        .HasForeignKey("CnaeID");

                    b.HasOne("SimuladoreSocial.Models.Governo.FPAS", "CodigoFpas")
                        .WithMany()
                        .HasForeignKey("CodigoFpasID");

                    b.HasOne("SimuladoreSocial.Models.Governo.CodigoPagamento", "CodigoPagamento")
                        .WithMany()
                        .HasForeignKey("CodigoPagamentoID");

                    b.HasOne("SimuladoreSocial.Models.Governo.CodigoTerceiros", "CodigoTerceiros")
                        .WithMany()
                        .HasForeignKey("CodigoTerceirosID");

                    b.HasOne("SimuladoreSocial.Models.Governo.LotacaoTributaria", "Lotacao")
                        .WithMany()
                        .HasForeignKey("LotacaoID");
                });
#pragma warning restore 612, 618
        }
    }
}
