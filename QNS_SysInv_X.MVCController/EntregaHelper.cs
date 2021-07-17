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

        public void Entrega()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[11];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objEntrega.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cliente";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objEntrega.Cliente;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@tipo";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objEntrega.Tipo;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@numeroDeSerie";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objEntrega.NumeroDeSerie;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@marca";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = objEntrega.Marca;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@fecha";
                parParameter[5].SqlDbType = SqlDbType.DateTime;
                parParameter[5].SqlValue = objEntrega.Fecha;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@contacto";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = objEntrega.Contacto;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@direccion";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = objEntrega.Dirrecion;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@cantidad";
                parParameter[8].SqlDbType = SqlDbType.Int;
                parParameter[8].SqlValue = objEntrega.Cantidad;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@descripcion";
                parParameter[9].SqlDbType = SqlDbType.VarChar;
                parParameter[9].Size = 50;
                parParameter[9].SqlValue = objEntrega.Descripcion;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@entregadoPor";
                parParameter[10].SqlDbType = SqlDbType.VarChar;
                parParameter[10].Size = 50;
                parParameter[10].SqlValue = objEntrega.EntregadoPor;

                cnGeneral.EjecutarSP(parParameter, "SPEntrega");

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
                parParameter[0].SqlValue = objEntrega.Opc;
                
                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPEntrega");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable Modificar()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[12];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objEntrega.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cliente";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objEntrega.Cliente;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@tipo";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objEntrega.Tipo;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@numeroDeSerie";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objEntrega.NumeroDeSerie;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@marca";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = objEntrega.Marca;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@fecha";
                parParameter[5].SqlDbType = SqlDbType.DateTime;
                parParameter[5].SqlValue = objEntrega.Fecha;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@contacto";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = objEntrega.Contacto;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@direccion";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = objEntrega.Dirrecion;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@cantidad";
                parParameter[8].SqlDbType = SqlDbType.Int;
                parParameter[8].SqlValue = objEntrega.Cantidad;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@descripcion";
                parParameter[9].SqlDbType = SqlDbType.VarChar;
                parParameter[9].Size = 50;
                parParameter[9].SqlValue = objEntrega.Descripcion;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@entregadoPor";
                parParameter[10].SqlDbType = SqlDbType.VarChar;
                parParameter[10].Size = 50;
                parParameter[10].SqlValue = objEntrega.EntregadoPor;

                parParameter[11] = new SqlParameter();
                parParameter[11].ParameterName = "@ID";
                parParameter[11].SqlDbType = SqlDbType.Int;
                parParameter[11].SqlValue = objEntrega.Id;

                cnGeneral.EjecutarSP(parParameter, "SPEntrega");
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable Buscar()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objEntrega.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@ID";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objEntrega.Id;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPEntrega");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }
    }
}
