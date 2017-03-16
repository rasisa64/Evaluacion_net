using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSBanco.BE
{
    public class BEOrdenPago
    {
        public string varIdBanco { get; set; }
        public string varIdSucursal { get; set; }
        public string varNombreSucursal { get; set; }
        public string varMonto { get; set; }
        public string varMoneda { get; set; }
        public string varEstado { get; set; }
        public string varFechaPago { get; set; }

    }
}
