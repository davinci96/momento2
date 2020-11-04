using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Contrato
{
    public class AccesoMetodosCRUDContrato
    {
        //opracion insert
        public int InsertContrato(int id, int id_conductor, int id_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDContrato.CrearComandoProcAlmacInsert_C();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@id_conductor", id_conductor);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return MetodosCRUDContrato.EjecutarComandoProcAlmacInsert_C(_comando);


        }

        //operacion select
        public static DataTable ListContrato()
        {
            SqlCommand _comando = MetodosCRUDContrato.CrearComandoSelect_C();

            _comando.CommandText = "select * from Contrato";

            return MetodosCRUDContrato.EjecutarComandoSelect_C(_comando);
        }

        //opracion update
        public int UpdateContrato(int id, int id_conductor, int id_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDContrato.CrearComandoProcAlmacUpdate_C();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@id_conductor", id_conductor);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return MetodosCRUDContrato.EjecutarComandoProcAlmacUpdate_C(_comando);


        }

        //opracion delete
        public int DeleteContrato(int id)
        {
            SqlCommand _comando = MetodosCRUDContrato.CrearComandoProcAlmacDelete_C();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDContrato.EjecutarComandoProcAlmacDelete_C(_comando);


        }
    }
}
