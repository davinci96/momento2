using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conductor
{
    public class MetodosCRUDConductor
    {
        //crear tipo comando INSERT
        public static SqlCommand CrearComandoProcAlmacInsert_V()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("addconductor", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;

        }


        //ejecutar comando insert
        public static int EjecutarComandoProcAlmacInsert_V(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        //crear tipo comando SELECT
        public static SqlCommand CrearComandoSelect_V()
        {
            //usar la conexion
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;

            //crear la instruccion select
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();

            _comando.CommandType = CommandType.Text;

            return _comando;

        }


        //ejecutar comando SELECT
        public static DataTable EjecutarComandoSelect_V(SqlCommand comando)
        {
            DataTable _table = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                adapter.Fill(_table);

            }
            catch (Exception EX)
            {
                throw EX;
            }
            finally
            {
                comando.Connection.Close();
            }
            return _table;
        }

        //actualizar update
        public static SqlCommand CrearComandoProcAlmacUpdate_Cond()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("update_conductor", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        public static int EjecutarComandoProcAlmacUpdate_Cond(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        //actualizar delete
        public static SqlCommand CrearComandoProcAlmacDelete_Cond()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("delete_conductor", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        public static int EjecutarComandoProcAlmacDelete_Cond(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
    }
}
