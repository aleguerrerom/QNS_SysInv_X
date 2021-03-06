using QNS_SysInv_X.MVCModel;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QNS_SysInv_X.MVCController
{
   public class EntregaHelper
    {

        Datos cnGeneral = null;
        Entrega objEntrega = null;
        DataTable tblDatos = null;

        public EntregaHelper(Entrega parObjEntrega)
        {
            objEntrega = parObjEntrega;
        }

        #region PROCESO DE ENTREGA
        public void Entrega()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objEntrega.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cliente";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objEntrega.Cliente;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@telefono";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objEntrega.Telefono;
                
                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@numFactura";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objEntrega.NumeroFactura;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@fecha";
                parParameter[4].SqlDbType = SqlDbType.DateTime;
                parParameter[4].SqlValue = objEntrega.Fecha;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@contacto";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objEntrega.Contacto;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@direccion";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = objEntrega.Dirrecion;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@entregadoPor";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = objEntrega.EntregadoPor;
                
                cnGeneral.EjecutarSP(parParameter, "SPEntrega");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            #endregion
          }
        }
      }
