using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBanco.Models
{
    public class Sucursal
    {
        public string varIdSucursal { get; set; }
        public string varNomSucursal { get; set; }
        public string varDireccionSucursal { get; set; }
        public string varFechRegistro { get; set; }

        public Sucursal() {
            varIdSucursal = "1" ;
            varNomSucursal = "La Encalada";
            varDireccionSucursal = "Av. La Encalada 123, Valle Hermoso";
            varFechRegistro = "16/03/2017";

        }
    }
}