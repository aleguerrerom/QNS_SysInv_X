using QNS_SysInv_X.MVCModel;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QNS_SysInv_X.MVCController
{
   public class BitacoraHelper
    {
        Datos cnGeneral = null;
        Bitacora objbitacora = null;
        DataTable tblDatos = null;


        public BitacoraHelper(Bitacora parObjBitacora)
        {
            objbitacora = parObjBitacora;
        }
        //RETORA TABLA CON LOS USUARIOS

        #region LISTAR
        public DataTable Listar()
        {
            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objbitacora.opc;
                
                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPBitacora");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }
        #endregion

        #region LOGS DE SESION

        public void LogSesion()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objbitacora.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@usuario";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objbitacora.Usuario;
                
                cnGeneral.EjecutarSP(parParameter, "SPBitacora");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region LOGS DE MOVIMIENTOS
        public void LogMovimientos()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[4];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objbitacora.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@usuario";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objbitacora.Usuario;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@movimiento";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objbitacora.Movimiento;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@detalle";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 100;
                parParameter[3].SqlValue = objbitacora.Detalle;
                cnGeneral.EjecutarSP(parParameter, "SPBitacora");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            #endregion
        }
    }
}
