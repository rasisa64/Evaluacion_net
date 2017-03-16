using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBanco.Models
{
    public class OrdenesPago
    {
        public string varMonto { get; set; }
        public string varMoneda { get; set; }
        public string varEstado { get; set; }
        public string varFechaPago { get; set; }

        public OrdenesPago() {
            varMonto = "1000";
            varMoneda = "Soles";
            varEstado = "Pagada";
            varFechaPago = "16/03/2017";
        }
    }
}