using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Vehiculo
{
    public class AccesoMetodosCRUDVehiculo
    {
        //opracion insert
        public int InsertVehiculo(int id, string marca, string modelo, string placa,int anio, int id_tv)
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcAlmacInsert_V();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@placa", placa);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@id_tv", id_tv);

            return MetodosCRUDVehiculo.EjecutarComandoProcAlmacInsert_V(_comando);


        }

        //operacion select
        public static DataTable ListtVehiculo()
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoSelect_V();

            _comando.CommandText = "select * from Vehiculo";

            return MetodosCRUDVehiculo.EjecutarComandoSelect_V(_comando);
        }

        //operacion Update
        public int UpdateVehiculo(int id, string marca, string modelo, string placa, int anio, int id_tv)
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcAlmacUpdate_V();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@placa", placa);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@id_tv", id_tv);

            return MetodosCRUDVehiculo.EjecutarComandoProcAlmacUpdate_V(_comando);


        }

        //operacion Delete
        public int DeleteVehiculo(int id)
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcAlmacDelete_V();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDVehiculo.EjecutarComandoProcAlmacDelete_V(_comando);


        }

    }
}
