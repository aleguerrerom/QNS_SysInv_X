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
   public class OportunidadesHelper
    {
        Datos cnGeneral = null;
        Oportunidades objOportunidades = null;
        DataTable tblDatos = null;

        public OportunidadesHelper(Oportunidades parObjOportunidades)
        {
            objOportunidades = parObjOportunidades;
        }

        public void Guardar()
        {
            try
            {

                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[7];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objOportunidades.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombrecliente";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objOportunidades.Nombrecliente;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@fechacierre";
                parParameter[2].SqlDbType = SqlDbType.DateTime;
                parParameter[2].SqlValue = objOportunidades.Fechacierre;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@marca";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objOportunidades.Marca;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@detalles";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 200;
                parParameter[4].SqlValue = objOportunidades.Detalles;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@presupuesto";
                parParameter[5].SqlDbType = SqlDbType.Int;
                parParameter[5].SqlValue = objOportunidades.Presupuesto;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@vendedor";
                parParameter[6].SqlDbType = SqlDbType.Int;
                parParameter[6].SqlValue = objOportunidades.Vendedor;


                cnGeneral.EjecutarSP(parParameter, "SPOportunidades");



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
                parParameter[0].SqlValue = objOportunidades.opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPOportunidades");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }


        public void Eliminar()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objOportunidades.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombrecliente";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objOportunidades.Nombrecliente;

                cnGeneral.EjecutarSP(parParameter, "SPOportunidades");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }


        public void Actualizar()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objOportunidades.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombrecliente";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objOportunidades.Nombrecliente;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@fechacierre";
                parParameter[2].SqlDbType = SqlDbType.DateTime;
                parParameter[2].SqlValue = objOportunidades.Fechacierre;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@marca";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objOportunidades.Marca;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@detalles";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 200;
                parParameter[4].SqlValue = objOportunidades.Detalles;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@presupuesto";
                parParameter[5].SqlDbType = SqlDbType.Int;
                parParameter[5].SqlValue = objOportunidades.Presupuesto;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@vendedor";
                parParameter[6].SqlDbType = SqlDbType.Int;
                parParameter[6].SqlValue = objOportunidades.Vendedor;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@id";
                parParameter[7].SqlDbType = SqlDbType.Int;
                parParameter[7].SqlValue = objOportunidades.Id;


                cnGeneral.EjecutarSP(parParameter, "SPOportunidades");


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }

}
