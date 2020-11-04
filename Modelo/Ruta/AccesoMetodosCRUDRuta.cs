using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Ruta
{
    public class AccesoMetodosCRUDRuta
    {
        //opracion insert
        public int InsertRuta(int id, string estacion, int id_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcAlmacInsert_R();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@estacion", estacion);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return MetodosCRUDRuta.EjecutarComandoProcAlmacInsert_R(_comando);


        }

        //operacion select
        public static DataTable ListRuta()
        {
            SqlCommand _comando = MetodosCRUDRuta.CrearComandoSelect_R();

            _comando.CommandText = "select * from Ruta";

            return MetodosCRUDRuta.EjecutarComandoSelect_R(_comando);
        }

        //opracion update
        public int UpdatetRuta(int id, string estacion, int id_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcAlmacUpdate_Ruta();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@estacion", estacion);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return MetodosCRUDRuta.EjecutarComandoProcAlmacUpdate_Ruta(_comando);


        }

        //opracion delete
        public int DeleteRuta(int id)
        {
            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcAlmacDelete_Ruta();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDRuta.EjecutarComandoProcAlmacDelete_Ruta(_comando);


        }
    }
}
