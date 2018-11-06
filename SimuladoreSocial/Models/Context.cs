using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimuladoreSocial.Models
{
    public class Context : DbContext
    {
        //Tabelas relacionadas ao cadastro de empresas
        public DbSet<Models.Empresas.Empresas> TEmpresas { get; set; }

        //Tabelas relacionadas as informações governamentais
        public DbSet<Models.Governo.CNAE> TCnae { get; set; }
        public DbSet<Models.Governo.ClassificacaoTributaria> TClassificacao { get; set; }
        public DbSet<Models.Governo.CodigoPagamento> TCodigoPagamento { get; set; }
        public DbSet<Models.Governo.CodigoTerceiros> TCodigoTerceiros { get; set; }
        public DbSet<Models.Governo.FPAS> TCodigoFPAS { get; set; }
        public DbSet<Models.Governo.LotacaoTributaria> TCodigoLotacao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-747001Q; Initial Catalog=DataBaseTeste; Integrated Security=True;Connect Timeout=30");
        }

    }
}
