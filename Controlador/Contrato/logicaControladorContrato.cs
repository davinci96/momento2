using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Conductor;
using Modelo.Contrato;

namespace Controlador.Contrato
{
    public class logicaControladorContrato
    {
        //negociar INSERT
        public int NegociarInsertContrato(int id, int id_conductor, int id_vehiculo)
        {
            AccesoMetodosCRUDContrato acceso = new AccesoMetodosCRUDContrato();

            return acceso.InsertContrato(id, id_conductor, id_vehiculo);
        }

        //negociar select
        public static DataTable NegociarSelectContrato()
        {
            return AccesoMetodosCRUDContrato.ListContrato();
        }

        //negociar update
        public int NegociarUpdatetContrato(int id, int id_conductor, int id_vehiculo)
        {
            AccesoMetodosCRUDContrato acceso = new AccesoMetodosCRUDContrato();

            return acceso.UpdateContrato(id, id_conductor, id_vehiculo);
        }

        //negociar delete
        public int NegociarDeleteContrato(int id)
        {
            AccesoMetodosCRUDContrato acceso = new AccesoMetodosCRUDContrato();

            return acceso.DeleteContrato(id);
        }
    }
}
