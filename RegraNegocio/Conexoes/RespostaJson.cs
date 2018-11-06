using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.Conexoes
{
    public class RespostaJson
    { 
        public object _Data { get; set; }
        public bool _Condicao { get; set; }
        public string _Mensagem { get; set; }
    }
}
