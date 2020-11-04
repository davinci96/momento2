using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Conductor;

namespace Controlador.Conductor
{
    public class logicaConductor
    {
        //negociar INSERT
        public int NegociarInsertConductor(int id, string nombre, string tipo_licencia, int id_vehiculo, int id_tipo_conductor)
        {
            AccesoMetodosCRUDConductor acceso = new AccesoMetodosCRUDConductor();

            return acceso.InsertConductor(id, nombre, tipo_licencia, id_vehiculo, id_tipo_conductor);
        }
        
        //negociar select
        public static DataTable NegociarSelectConductor()
        {
            return AccesoMetodosCRUDConductor.ListConductor();
        }

        //negociar update
        public int NegociarUpdateConductor(int id, string nombre, string tipo_licencia, int id_vehiculo, int id_tipo_conductor)
        {
            AccesoMetodosCRUDConductor negociarAcceso = new AccesoMetodosCRUDConductor();

            return negociarAcceso.UpdateConductor(id, nombre, tipo_licencia, id_vehiculo, id_tipo_conductor);
        }

        //negociar delete
        public int NegociarDeleteConductor(int id)
        {
             AccesoMetodosCRUDConductor negociarAcceso = new AccesoMetodosCRUDConductor();

            return negociarAcceso.DeleteConductor(id);
        }
    }
}
