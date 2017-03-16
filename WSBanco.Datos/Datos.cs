using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;
using System.Data;

namespace WSBanco.Datos
{
    public class Datos
    {
        public static List<BE.BEOrdenPago> Cargar_OrdenesPago_DB(string idBanc, string idSuc, string TipMon)
        {

            List<BE.BEOrdenPago> Orden_lista = new List<BE.BEOrdenPago>();
            string nameConnection = DataConfiguration.Default.OracleConn;
            OracleDataReader _dataReader = null;
            OracleConnection con = new OracleConnection(nameConnection);
            try
            {
                con.Open();

                OracleCommand cursCmd = con.CreateCommand();
                cursCmd.CommandText = "LOGISTICA.SP_ORDEN_PAGO";
                cursCmd.CommandType = CommandType.StoredProcedure;

                OracleParameter p_idBanc = new OracleParameter();
                p_idBanc.OracleDbType = OracleDbType.Varchar2;
                p_idBanc.Direction = ParameterDirection.Input;
                p_idBanc.Value = idBanc;
                cursCmd.Parameters.Add(p_idBanc);

                OracleParameter p_idSuc = new OracleParameter();
                p_idSuc.OracleDbType = OracleDbType.Varchar2;
                p_idSuc.Direction = ParameterDirection.Input;
                p_idSuc.Value = idSuc;
                cursCmd.Parameters.Add(p_idSuc);

                OracleParameter p_TipMon = new OracleParameter();
                p_TipMon.OracleDbType = OracleDbType.Varchar2;
                p_TipMon.Direction = ParameterDirection.Input;
                p_TipMon.Value = TipMon;
                cursCmd.Parameters.Add(p_TipMon);

                cursCmd.Parameters.Add("outcursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                _dataReader = cursCmd.ExecuteReader();

                while (_dataReader.Read())
                {
                    BE.BEOrdenPago objOrden = new BE.BEOrdenPago();
                    objOrden.varIdBanco = _dataReader["wav_idbanco"].ToString();
                    objOrden.varIdSucursal = _dataReader["wav_IdSucursal"].ToString();
                    objOrden.varNombreSucursal = _dataReader["wav_NombreSucursal"].ToString();
                    objOrden.varMonto = _dataReader["wav_Monto"].ToString();
                    objOrden.varMoneda = _dataReader["wav_Moneda"].ToString();
                    objOrden.varEstado = _dataReader["wav_Estado"].ToString();
                    objOrden.varFechaPago = _dataReader["wav_FechaPago"].ToString();


                    Orden_lista.Add(objOrden);
                }

                _dataReader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }


            return Orden_lista;
        }


        
        public static List<BE.BESucursal> Cargar_ObtenerSucursal_DB(String idBanc)
        {

            List<BE.BESucursal> Sucursal_lista = new List<BE.BESucursal>();
            string nameConnection = DataConfiguration.Default.OracleConn;
            OracleDataReader _dataReader = null;
            OracleConnection con = new OracleConnection(nameConnection);
            try
            {
                con.Open();

                OracleCommand cursCmd = con.CreateCommand();
                cursCmd.CommandText = "LOGISTICA.SP_SUCURSAL";
                cursCmd.CommandType = CommandType.StoredProcedure;

                OracleParameter p_idBanc = new OracleParameter();
                p_idBanc.OracleDbType = OracleDbType.Varchar2;
                p_idBanc.Direction = ParameterDirection.Input;
                p_idBanc.Value = idBanc;
                cursCmd.Parameters.Add(p_idBanc);

                cursCmd.Parameters.Add("outcursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                _dataReader = cursCmd.ExecuteReader();

                while (_dataReader.Read())
                {
                    BE.BESucursal objSucursal = new BE.BESucursal();
                    objSucursal.varIdSucursal = _dataReader["wav_IdSucursal"].ToString();
                    objSucursal.varNomSucursal = _dataReader["wav_NombreSucursal"].ToString();
                    objSucursal.varDireccionSucursal = _dataReader["wav_DirSucursal"].ToString();
                    objSucursal.varFechRegistro = _dataReader["wav_FechRegistro"].ToString();
                  
                    Sucursal_lista.Add(objSucursal);
                }

                _dataReader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }


            return Sucursal_lista;
        }


    }
}
