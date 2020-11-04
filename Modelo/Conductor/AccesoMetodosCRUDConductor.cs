using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conductor
{
    public class AccesoMetodosCRUDConductor
    {
        //opracion insert
        public int InsertConductor(int id, string nombre, string tipo_licencia, int id_vehiculo, int id_tipo_conductor)
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcAlmacInsert_V();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@tipo_licencia", tipo_licencia);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", id_tipo_conductor);

            return MetodosCRUDConductor.EjecutarComandoProcAlmacInsert_V(_comando);


        }


        //operacion select
        public static DataTable ListConductor()
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoSelect_V();

            _comando.CommandText = "select * from Conductor";

            return MetodosCRUDConductor.EjecutarComandoSelect_V(_comando);
        }

        //opracion update
        public int UpdateConductor(int id, string nombre, string tipo_licencia, int id_vehiculo, int id_tipo_conductor)
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcAlmacUpdate_Cond();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@tipo_licencia", tipo_licencia);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", id_tipo_conductor);

            return MetodosCRUDConductor.EjecutarComandoProcAlmacUpdate_Cond(_comando);


        }

        //operacion Delete
        public int DeleteConductor(int id)
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcAlmacDelete_Cond();

            _comando.Parameters.AddWithValue("@id", id);


            return MetodosCRUDConductor.EjecutarComandoProcAlmacDelete_Cond(_comando);
        }
    }
}
