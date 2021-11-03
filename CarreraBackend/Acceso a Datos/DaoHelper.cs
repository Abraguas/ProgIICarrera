using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

//@"Data Source=DESKTOP-OPJRSO7;Initial Catalog=db_carrera1;Integrated Security=True";(mati)
//@"Data Source=localhost;Initial Catalog=db_carrera;Integrated Security=True" (franco)
//@"Data Source=LAPTOP-6SKGEOLC\SQLEXPRESS;Initial Catalog=db_carrera;Integrated Security=True" (sofi)
namespace CarreraBackend.Acceso_a_Datos
{
    class DaoHelper
    {
        private string cadenaConexion;
        private SqlConnection conexion;
        private SqlCommand comando;

        public DaoHelper()
        {
            cadenaConexion = @"Data Source=LAPTOP-6SKGEOLC\SQLEXPRESS;Initial Catalog=db_carrera;Integrated Security=True";
            conexion = new SqlConnection(cadenaConexion);
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
        public object EjecutarSPSalida(string sp, string nomParametro)
        {
            comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.CommandText = sp;
            SqlParameter param = new SqlParameter();
            param.ParameterName = nomParametro;
            param.Direction = ParameterDirection.Output;
            param.SqlDbType = SqlDbType.Int;
            comando.Parameters.Add(param);
            try
            {
                conexion.Open();
                comando.ExecuteReader();
                conexion.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return param.Value;
        }
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
                throw e;
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
                foreach (List<Parametro> parametros in parametrosDetalles)
                {
                    comando = new SqlCommand(spDetalles, conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    foreach (Parametro parametroD in parametros)
                    {
                        comando.Parameters.AddWithValue(parametroD.Nombre, parametroD.Valor);
                    }
                    comando.ExecuteNonQuery();
                }
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