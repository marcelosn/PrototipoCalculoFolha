using SimuladoreSocial.Models.Governo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimuladoreSocial.Models.Empresas
{
    public class Empresas
    {
        public int ID { get; set; }


        //Informações cadastrais

        public string RazaoSocial { get; set; }  

        public string NomeFantasia { get; set; }

        public string NaturezaJuridica { get; set; }

        public string DataAbertura { get; set; }

        public SituacaoEmpresa Situacao { get; set; }

        public string Inscricao { get; set; }

        public PorteEmpresa Porte { get; set; }

        public bool EmpresaMatriz { get; set; }




        //Parâmetros de calculo para folha

        public SituacaoESocial ESocial { get; set; } 

        public bool OptanteSimplesNacional { get; set; }

        public bool PagaPercetualEmpregadores { get; set; }

        public CodigoPagamento CodigoPagamento { get; set; }

        public int? CodigoPagamentoID { get; set; }

        public CodigoTerceiros CodigoTerceiros { get; set; }

        public int? CodigoTerceirosID { get; set; }

        public FPAS CodigoFpas { get; set; }

        public int? CodigoFpasID { get; set; }

        public double FPASPercentual { get; set; }

        public CNAE CNAE { get; set; }

        public int? CnaeID { get; set; }

        public ClassificacaoTributaria Classificacao { get; set; }

        public int? ClassificacaoID { get; set; }

        public LotacaoTributaria Lotacao { get; set; }

        public double RAT { get; set; }

        public double AliquotaFAP { get; set; }
    }
}
