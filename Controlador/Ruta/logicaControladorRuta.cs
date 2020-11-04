using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Ruta;

namespace Controlador.Ruta
{
    public class logicaControladorRuta
    {
        //negociar INSERT
        public int NegociarInsertRuta(int id, string estacion, int id_vehiculo)
        {
            AccesoMetodosCRUDRuta acceso = new AccesoMetodosCRUDRuta();

            return acceso.InsertRuta(id, estacion, id_vehiculo);
        }

        //negociar select
        public static DataTable NegociarSelectRuta()
        {
            return AccesoMetodosCRUDRuta.ListRuta();
        }

        //negociar update
        public int NegociarUpdateRuta(int id, string estacion, int id_vehiculo)
        {
            AccesoMetodosCRUDRuta acceso = new AccesoMetodosCRUDRuta();

            return acceso.UpdatetRuta(id, estacion, id_vehiculo);
        }

        //negociar delete
        public int NegociarDeleteRuta(int id)
        {
            AccesoMetodosCRUDRuta acceso = new AccesoMetodosCRUDRuta();

            return acceso.DeleteRuta(id);
        }
    }
}
