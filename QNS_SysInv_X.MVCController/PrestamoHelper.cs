using QNS_SysInv_X.MVCModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNS_SysInv_X.MVCController
{
   public class PrestamoHelper
    {

        Datos cnGeneral = null;
        Prestamos objPrestamo = null;
        DataTable tblDatos = null;


        public PrestamoHelper(Prestamos parObjPrestamo)
        {
            objPrestamo = parObjPrestamo;
        }

        public void Prestamo()
        {
            try
            {

                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objPrestamo.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@ID_Articulo";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objPrestamo.Id_articulo;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@ID_Cliente";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = objPrestamo.Id_cliente;

                cnGeneral.EjecutarSP(parParameter, "SPInventario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
