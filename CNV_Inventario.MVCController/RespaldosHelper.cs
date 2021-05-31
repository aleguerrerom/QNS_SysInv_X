using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CNV_Inventario.MVCModel;
using System.Data;

namespace CNV_Inventario.MVCController
{
    public class RespaldosHelper
    {

        Datos cnGeneral = null;
        Respaldos objRepaldos = null;
        DataTable tblDatos = null;

        public RespaldosHelper(Respaldos parObjRespaldos)
        {
            objRepaldos = parObjRespaldos;
        }

        public void Guardar()
        {
            try
            {

                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[4];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objRepaldos.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 150;
                parParameter[1].SqlValue = objRepaldos.Nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@directorio";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 200;
                parParameter[2].SqlValue = objRepaldos.Directorio;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@doc";
                parParameter[3].SqlDbType = SqlDbType.VarBinary;
               
                parParameter[3].SqlValue = objRepaldos.Doc;


                cnGeneral.EjecutarSP(parParameter, "SPRespaldos");



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

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
                parParameter[0].SqlValue = objRepaldos.opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPRespaldos");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }


    }
}
