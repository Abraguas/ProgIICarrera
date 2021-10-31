using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CarreraBackend.Acceso_a_Datos
{
    class DaoHelper
    {
        private static DaoHelper instancia;
        private string cadenaConexion;
        private SqlConnection conexion;
        private SqlCommand comando;

        private DaoHelper()
        {
            cadenaConexion = "";
            conexion = new SqlConnection(cadenaConexion);
        }
        public static DaoHelper ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new DaoHelper();
            }
            return instancia;
        }

        public DataTable ConsultarDB(string nombreSP)
        {
            DataTable tabla = new DataTable();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            try
            {
                conexion.Open();
                tabla.Load(comando.ExecuteReader());
                conexion.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return tabla;
        }
        public DataTable ConsultarConParametro(string nombreSP, Parametro parametro)
        {
            DataTable tabla = new DataTable();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.AddWithValue(parametro.Nombre,parametro.Valor);
            try
            {
                conexion.Open();
                tabla.Load(comando.ExecuteReader());
                conexion.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return tabla;
        }
        //public object EjecutarSPSalida(string sp, string nomParametro) [--Borrar si no la usamos--]
        //{
        //    comando = new SqlCommand();
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.Connection = conexion;
        //    comando.CommandText = sp;
        //    SqlParameter param = new SqlParameter();
        //    param.ParameterName = nomParametro;
        //    param.Direction = ParameterDirection.Output;
        //    param.SqlDbType = SqlDbType.Int;
        //    comando.Parameters.Add(param);
        //    try
        //    {
        //        conexion.Open();
        //        comando.ExecuteReader();
        //        conexion.Close();
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }
        //    return param.Value;
        //}
        public bool EjecutarSpEntrada(string nombreSP, List<Parametro> parametros) 
        {
            bool flag = true;
            try
            {
                comando = new SqlCommand(nombreSP, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                foreach (Parametro paramtetro in parametros)
                {
                    comando.Parameters.AddWithValue(paramtetro.Nombre, paramtetro.Valor);
                }

                conexion.Open();
                comando.ExecuteNonQuery();
               
            }
            catch (SqlException e)
            {
                //throw e;
                flag = false;
            }
            finally
            {
                conexion.Close();
            }
            return flag;
        }
        public bool InsertarMaestroDetalle(string spMaestro, List<Parametro> parametrosMaestro,
                                            string spDetalles, List<List<Parametro>> parametrosDetalles)
        {
            bool flag = true;
            //MAESTRO
            SqlTransaction transaccion = null;
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                comando = new SqlCommand(spMaestro, conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                foreach (Parametro paramtetroM in parametrosMaestro)
                {
                    comando.Parameters.AddWithValue(paramtetroM.Nombre, paramtetroM.Valor);
                }
                comando.ExecuteNonQuery();

                //DETALLES
                comando = new SqlCommand(spDetalles, conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                foreach (List<Parametro> parametros in parametrosDetalles)
                {
                    foreach (Parametro parametroD in parametros)
                    {
                        comando.Parameters.AddWithValue(parametroD.Nombre, parametroD.Valor);
                    }
                }
                comando.ExecuteNonQuery();
                transaccion.Commit();
            }
            catch (SqlException e)
            {
                transaccion.Rollback();
                throw e;

            }
            finally
            {
                conexion.Close();
            }
            return flag;
        }


        public object ConsultarEscalar(string sp, Parametro parametro)
        {
            object resultado;
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sp;
            comando.Parameters.AddWithValue(parametro.Nombre, parametro.Valor);
            try
            {
                conexion.Open();
                //Devuelve el valor de la primera columna en la primera fila
                resultado = comando.ExecuteScalar();
                conexion.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return resultado;
        }
    }
}