using System;
using QNS_SysInv_X.MVCModel;
using System.Data.SqlClient;
using System.Data;

namespace QNS_SysInv_X.MVCController
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

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@correo";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = objUsuarios.Correo;

                cnGeneral.EjecutarSP(parParameter, "SPUsuario");



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

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@correo";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = objUsuarios.Correo;

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
                parParameter[1].ParameterName = "@usuario";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = objUsuarios.Usuario;

                cnGeneral.EjecutarSP(parParameter, "SPUsuario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        
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

        public void CambiarClave()
        {
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
             

                cnGeneral.EjecutarSP(parParameter, "SPUsuario");



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
                parParameter[0].SqlValue = objUsuarios.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@usuario";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = objUsuarios.Usuario;



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

