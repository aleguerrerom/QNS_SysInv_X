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
    public class VendedoresHelper
    {
        Datos cnGeneral = null;
        Vendedores objVendedores = null;
        DataTable tblDatos = null;


        public VendedoresHelper(Vendedores parObjVendedores)
        {
            objVendedores = parObjVendedores;
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
                parParameter[0].SqlValue = objVendedores.opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPVendedor");

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
                parParameter[0].SqlValue = objVendedores.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objVendedores.Cedula;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombre";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objVendedores.Nombre;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@apellido1";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objVendedores.Apellido1;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@apellido2";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = objVendedores.Apellido2;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@genero";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objVendedores.Genero;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@fechaNacimiento";
                parParameter[6].SqlDbType = SqlDbType.Date;
                parParameter[6].SqlValue = objVendedores.Fechanacimiento;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@correo";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = objVendedores.Correo;

                cnGeneral.EjecutarSP(parParameter, "SPVendedor");



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
                parParameter[0].SqlValue = objVendedores.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objVendedores.Cedula;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombre";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objVendedores.Nombre;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@apellido1";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objVendedores.Apellido1;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@apellido2";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = objVendedores.Apellido2;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@genero";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objVendedores.Genero;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@fechaNacimiento";
                parParameter[6].SqlDbType = SqlDbType.Date;
                parParameter[6].SqlValue = objVendedores.Fechanacimiento;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@correo";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = objVendedores.Correo;

                cnGeneral.EjecutarSP(parParameter, "SPVendedor");
                
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
                parParameter[0].SqlValue = objVendedores.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objVendedores.Cedula;

                cnGeneral.EjecutarSP(parParameter, "SPVendedor");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


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
                parParameter[0].SqlValue = objVendedores.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objVendedores.Cedula;



                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPVendedor");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }


    }
}
