using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimuladoreSocial.Models.Governo
{
    public class CNAE
    {
        public int ID { get; set; }

        public string CodigoCNAE { get; set; }

        public string Descricao { get; set; }

        public double RAT { get; set; }

        public int FPAS { get; set; }
    }
}
