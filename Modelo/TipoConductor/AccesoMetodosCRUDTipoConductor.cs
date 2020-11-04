using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoConductor
{
    public class AccesoMetodosCRUDTipoConductor
    {
        //opracion insert
        public int InsertTipoConductor(int id, string tipo_persona)
        {
            SqlCommand _comando = MetodosCRUDTipoConductor.CrearComandoProcAlmacInsert_V();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@tipo_persona", tipo_persona);

            return MetodosCRUDTipoConductor.EjecutarComandoProcAlmacInsert_V(_comando);


        }

        //operacion select
        public static DataTable ListTipoConductor()
        {
            SqlCommand _comando = MetodosCRUDTipoConductor.CrearComandoSelect_V();

            _comando.CommandText = "select * from Tipo_conductor";

            return MetodosCRUDTipoConductor.EjecutarComandoSelect_V(_comando);
        }

        //opracion update
        public int UpdatetTipoConductor(int id, string tipo_persona)
        {
            SqlCommand _comando = MetodosCRUDTipoConductor.CrearComandoProcAlmacUpdate_tcond();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@tipo_persona", tipo_persona);

            return MetodosCRUDTipoConductor.EjecutarComandoProcAlmacUpdate_tcond(_comando);


        }

        //operacion Delete
        public int DeleteTipoConductor(int id)
        {
            SqlCommand _comando = MetodosCRUDTipoConductor.CrearComandoProcAlmacDelete_tcond();

            _comando.Parameters.AddWithValue("@id", id);


            return MetodosCRUDTipoConductor.EjecutarComandoProcAlmacDelete_tcond(_comando);
        }
    }
}
