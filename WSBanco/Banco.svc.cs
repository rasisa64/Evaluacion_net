using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WSBanco
{
    public class Banco : IBanco
    {
        List<BE.BESucursal> lista_Sucursales = new List<BE.BESucursal>(){
                new BE.BESucursal(){
                    varIdBanco = "1",
                    varIdSucursal ="1",
                    varNomSucursal ="La Encalada",
                    varDireccionSucursal ="Calle la Encalada 1123",
                    varFechRegistro ="SOLES"
                    },

                new BE.BESucursal(){
                    varIdBanco = "1",
                    varIdSucursal ="2",
                    varNomSucursal ="La Marina",
                    varDireccionSucursal ="Av. La Marina 3458",
                    varFechRegistro ="SOLES"
                    },
        };
    

        List<BE.BEOrdenPago> lista_ordenes = new List<BE.BEOrdenPago>(){
                new BE.BEOrdenPago(){
                    varIdBanco = "1",
                    varIdSucursal ="1",
                    varNombreSucursal ="La Encalada",
                    varMonto ="1500",
                    varMoneda ="SOLES",
                    varEstado ="PAGADA",
                    varFechaPago ="16-03-2017",
                    },

                new BE.BEOrdenPago(){
                    varIdBanco = "1",
                    varIdSucursal ="2",
                    varNombreSucursal ="La Marina",
                    varMonto ="20000",
                    varMoneda ="SOLES",
                    varEstado ="PAGADA",
                    varFechaPago ="16-03-2017"
                    },

        };

        private List<BE.BEOrdenPago> lista_orden(string idBanc, string idSuc, string TipMon)
        {
            return lista_ordenes
                .Where(x => x.varIdBanco == idBanc && x.varIdSucursal == idSuc && x.varMoneda == TipMon.ToUpper())
                .Select(s => s).ToList<BE.BEOrdenPago>();
        }

        public List<BE.BEOrdenPago> ordenesPago(string idBanc, string idSuc, string TipMon)
        {
            List<BE.BEOrdenPago> rpta = new List<BE.BEOrdenPago>();
            rpta = null;

            //Con Base de Datos
            //rpta = Datos.Datos.Cargar_OrdenesPago_DB(idBanc, idSuc, TipMon);

            rpta = lista_orden(idBanc, idSuc, TipMon);

            return rpta;
        }

        public List<BE.BESucursal> obtenerSucursal(string idBanc)
        {
            List<BE.BESucursal> rpta = new List<BE.BESucursal>();
            rpta = null;

            //Con Base de Datos
            //rpta = Datos.Datos.Cargar_ObtenerSucursal_DB(idBanc);
            rpta = lista_Sucursal(idBanc);

            return rpta;
        }

        private List<BE.BESucursal> lista_Sucursal(string idBanc)
        {
            return lista_Sucursales
                .Where(x => x.varIdBanco == idBanc)
                .Select(s => s).ToList<BE.BESucursal>();
        }


    }
}
