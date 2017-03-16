using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBanco.Models
{
    public class Banco
    {
        public string varIdBanco { get; set; }
        public string varNomBanco { get; set; }
        public string varDireccionBanco { get; set; }
        public string varFechRegistro { get; set; }

        public Banco() {
            varIdBanco = "1";
            varNomBanco = "Interbank";
            varDireccionBanco = "Av. La Encalada 123, Valle Hermoso";
            varFechRegistro = "16/03/2017";
        }
    }


}