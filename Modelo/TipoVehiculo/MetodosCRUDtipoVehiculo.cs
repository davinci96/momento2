using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoVehiculo
{
    public class MetodosCRUDtipoVehiculo
    {
        //crear tipo comando INSERT
        public static SqlCommand CrearComandoProcAlmacInsert_tv()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("addTipo_vehiculo", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        public static int EjecutarComandoProcAlmacInsert_tv(SqlCommand comando)
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

        //crear comando select
        public static SqlCommand CrearComandoSelect_tv()
        {
            //usar conexion
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;

            //crear la instruccion
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;

            return _comando;
        }

        public static DataTable EjecutarComandoSelect_tv(SqlCommand comando)
        {
            DataTable _table = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                adapter.Fill(_table);
                
            }
            catch (Exception EX) { throw EX; }
            finally{ comando.Connection.Close();}

            return _table;
        }

        //actualizar update
        public static SqlCommand CrearComandoProcAlmacUpdate_tv()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("updateTipo_vehiculo", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        public static int EjecutarComandoProcAlmacUpdate_tv(SqlCommand comando)
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
        public static SqlCommand CrearComandoProcAlmacDelete_tv()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("deleteTipo_vehiculo", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        public static int EjecutarComandoProcAlmacDelete_tv(SqlCommand comando)
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
