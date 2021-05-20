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
    public class UsuariosHelper
    {
        Datos cnGeneral = null;
        Usuarios objUsuarios = null;
        DataTable tblDatos = null;


        public UsuariosHelper(Usuarios parObjUsuarios)
        {
            objUsuarios = parObjUsuarios;
        }
        //RETORA TABLA CON LOS USUARIOS
        /*
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
                parParameter[0].SqlValue = objUsuarios.opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPUsuario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }
        */
        //GUARDA USUARIOS
        public void Guardar()
        {
            try
            {

                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[7];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuarios.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@usuario";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objUsuarios.Usuario;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@clave";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objUsuarios.Clave;
                
                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@activo";
                parParameter[3].SqlDbType = SqlDbType.Bit;
                parParameter[3].SqlValue = objUsuarios.Activo;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@rol";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = objUsuarios.Rol;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@nombre";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objUsuarios.Nombre;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@apellido";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = objUsuarios.Apellido;
                
                cnGeneral.EjecutarSP(parParameter, "SPUsuario");



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        /*
        public void Actualizar()
        {



            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[10];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuarios.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = objUsuarios.Nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@cedula";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 20;
                parParameter[2].SqlValue = objUsuarios.Cedula;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@fechaNacimiento";
                parParameter[3].SqlDbType = SqlDbType.DateTime;
                parParameter[3].SqlValue = objUsuarios.FechaNacimiento;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@genero";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 20;
                parParameter[4].SqlValue = objUsuarios.Genero;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@telefono";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 20;
                parParameter[5].SqlValue = objUsuarios.Telefono;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@correo";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 30;
                parParameter[6].SqlValue = objUsuarios.Correo;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@perfil";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 20;
                parParameter[7].SqlValue = objUsuarios.Perfil;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@usuario";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 20;
                parParameter[8].SqlValue = objUsuarios.Usuario;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@clave";
                parParameter[9].SqlDbType = SqlDbType.VarChar;
                parParameter[9].Size = 20;
                parParameter[9].SqlValue = objUsuarios.Clave;

                cnGeneral.EjecutarSP(parParameter, "SPUsuario");



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
                parParameter[0].SqlValue = objUsuarios.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = objUsuarios.Cedula;

                cnGeneral.EjecutarSP(parParameter, "SPUsuario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        */
        public DataTable ValidarLogin()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuarios.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@usuario";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objUsuarios.Usuario;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@clave";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objUsuarios.Clave;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPUsuario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }
    }
}

