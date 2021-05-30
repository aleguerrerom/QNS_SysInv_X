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
    public class RolesHelper

    {
        Datos cnGeneral = null;
        Roles objRoles = null;
        DataTable tblDatos = null;

        public RolesHelper(Roles parobjRoles)
        {
            objRoles = parobjRoles;
        }

        public void GuardarRol()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objRoles.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objRoles.Nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@inventario";
                parParameter[2].SqlDbType = SqlDbType.Bit;
                parParameter[2].SqlValue = objRoles.Inventario;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@usuarios";
                parParameter[3].SqlDbType = SqlDbType.Bit;
                parParameter[3].SqlValue = objRoles.Usuarios;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@prestamo";
                parParameter[4].SqlDbType = SqlDbType.Bit;
                parParameter[4].SqlValue = objRoles.Prestamo;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@entrega";
                parParameter[5].SqlDbType = SqlDbType.Bit;
                parParameter[5].SqlValue = objRoles.Entrega;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@roles";
                parParameter[6].SqlDbType = SqlDbType.Bit;
                parParameter[6].SqlValue = objRoles.Roless;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@bitacora";
                parParameter[7].SqlDbType = SqlDbType.Bit;
                parParameter[7].SqlValue = objRoles.Bitacora;

                cnGeneral.EjecutarSP(parParameter, "SPRoles");
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
                parParameter[0].SqlValue = objRoles.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = objRoles.Nombre;

                cnGeneral.EjecutarSP(parParameter, "SPUsuario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }


        public void ActualizarRol()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objRoles.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objRoles.Nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@inventario";
                parParameter[2].SqlDbType = SqlDbType.Bit;
                parParameter[2].SqlValue = objRoles.Inventario;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@usuarios";
                parParameter[3].SqlDbType = SqlDbType.Bit;
                parParameter[3].SqlValue = objRoles.Usuarios;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@prestamo";
                parParameter[4].SqlDbType = SqlDbType.Bit;
                parParameter[4].SqlValue = objRoles.Prestamo;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@entrega";
                parParameter[5].SqlDbType = SqlDbType.Bit;
                parParameter[5].SqlValue = objRoles.Entrega;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@roles";
                parParameter[6].SqlDbType = SqlDbType.Bit;
                parParameter[6].SqlValue = objRoles.Roless;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@bitacora";
                parParameter[7].SqlDbType = SqlDbType.Bit;
                parParameter[7].SqlValue = objRoles.Bitacora;

                cnGeneral.EjecutarSP(parParameter, "SPRoles");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarRol()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objRoles.opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPRoles");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable BusquedaPermisoRol()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objRoles.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@ID";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objRoles.ID1;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPRoles");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }
    }


}
