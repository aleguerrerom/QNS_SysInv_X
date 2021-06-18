﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace CNV_Inventario.MVCModel
{
    public class Datos
    {
        #region Declaracion de Variables

        SqlConnection cnnConexion = null;
        SqlCommand cmdComando = null;
        SqlDataAdapter daAdaptador = null;
        DataTable Dtt = null;
        public string strCadenaConexion = string.Empty;

        #endregion

        #region Constructor

        public Datos()
        {
            strCadenaConexion = @"Data Source=192.168.50.15,51688; initial catalog=DB_CNV; user id=sa; password=1234QWer";
            // modificar el string de coneccion en gestinar cursos en linea 262, para poder buscar esrudiantes y verificar estado...
            // strCadenaConexion = @"Data Source= DESKTOP-5O1V857\SQLEXPRESS;  Initial Catalog = DB_CNV; Integrated Security=SSPI";

        }



        #endregion

        #region Metodos a Ejecutar


        public void EjecutarSP(SqlParameter[] parParametros, string parSPName)
        {
            // dtDatos = new DataSet();

            try
            {
                //Instanciamos el objeto conexion con la cadena de conexion.
                cnnConexion = new SqlConnection(strCadenaConexion);
                //Instanciamos el objeto comando con el TSQL y conexion a utilizar.
                cmdComando = new SqlCommand();//(parTSQL, cnnConexion);
                cmdComando.Connection = cnnConexion;
                //Abrimos la conexion
                cnnConexion.Open();
                //Asignamos el tipo de comando a ejecutar.
                cmdComando.CommandType = CommandType.StoredProcedure;
                //Agregamos el nombre del Srore procedure.
                cmdComando.CommandText = parSPName;
                //Agregmos los parametros a ejecutar
                cmdComando.Parameters.AddRange(parParametros);
                //Ejecutamos el TSQL(Transaction SQL) en el servidor.
                cmdComando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                cnnConexion.Dispose();
                cmdComando.Dispose();

            }

        }








        public DataTable RetornaTabla(SqlParameter[] parParametros, string parTSQL)
        {
            Dtt = null;
            try
            {
                Dtt = new DataTable();
                //Instanciamos el objeto conexion con la cadena de conexion.
                cnnConexion = new SqlConnection(strCadenaConexion);
                //Instanciamos el objeto comando con el TSQL
                cmdComando = new SqlCommand();//(parTSQL, cnnConexion);
                cmdComando.Connection = cnnConexion;
                //Asignamos el tipo de comando a ejecutar.
                cmdComando.CommandType = CommandType.StoredProcedure;
                //Agregamos el nombre del Srore procedure.
                cmdComando.CommandText = parTSQL;
                //Agregmos los parametros a ejecutar
                cmdComando.Parameters.AddRange(parParametros);
                //Instanciamos el objeto Adaptador con el comando a utilizar
                daAdaptador = new SqlDataAdapter(cmdComando);
                //Llenamos el Dataset con el adaptador de datos.
                daAdaptador.Fill(Dtt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnnConexion.Dispose();
                cmdComando.Dispose();
                daAdaptador.Dispose();
            }
            return Dtt;
        }


        #endregion
    }
}
