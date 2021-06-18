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
    public class ClientesHelper
    {
        Datos cnGeneral = null;
        Clientes objClientes = null;
        DataTable tblDatos = null;


        public ClientesHelper(Clientes parObjClientes)
        {
            objClientes = parObjClientes;
        }
        //RETORA TABLA CON LOS USUARIOS

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
                parParameter[0].SqlValue = objClientes.opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPClientes");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        //GUARDA USUARIOS
        public void Guardar()
        {
            try
            {

                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objClientes.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@tipo";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objClientes.Tipo;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@cedula";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = objClientes.Cedula;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@acontacto";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objClientes.Contacto;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@telefono";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = objClientes.Telefono;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@correo";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objClientes.Correo;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@direccion";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 200;
                parParameter[6].SqlValue = objClientes.Direccion;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@agente";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = objClientes.Agente;

                cnGeneral.EjecutarSP(parParameter, "SPClientes");



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
                parParameter[0].SqlValue = objClientes.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@tipo";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objClientes.Tipo;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@cedula";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = objClientes.Cedula;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@acontacto";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objClientes.Contacto;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@telefono";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = objClientes.Telefono;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@correo";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objClientes.Correo;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@direccion";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 200;
                parParameter[6].SqlValue = objClientes.Direccion;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@agente";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = objClientes.Agente;
                cnGeneral.EjecutarSP(parParameter, "SPClientes");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


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
                parParameter[0].SqlValue = objClientes.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objClientes.Cedula;

                cnGeneral.EjecutarSP(parParameter, "SPClientes");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

     

    }
}
