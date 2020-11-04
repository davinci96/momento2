using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.TipoVehiculo;

namespace Controlador.TipoVehiculo
{
    public class logicaControladorTipoVehiculo
    {

        //negociar INSERT
        public int NegociarInsertTipoVehiculo(int id, string name)
        {
            AccesoMetodosCRUDTipoVehiculo negociarAcceso = new AccesoMetodosCRUDTipoVehiculo();

            return negociarAcceso.InsertTipoVehiculo(id, name);
        }


        //negociar concultas select
        public static DataTable NegociarSelectTipoVehiculo()
        {
            return AccesoMetodosCRUDTipoVehiculo.ListTipoVehiculo();
        }

        //negociar update
        public int NegociarUpdateTipoVehiculo(int id, string name)
        {
            AccesoMetodosCRUDTipoVehiculo negociarAcceso = new AccesoMetodosCRUDTipoVehiculo();

            return negociarAcceso.UpdateTipoVehiculo(id, name);
        }

        //negociar delete
        public int NegociarDeleteTipoVehiculo(int id)
        {
            AccesoMetodosCRUDTipoVehiculo negociarAcceso = new AccesoMetodosCRUDTipoVehiculo();

            return negociarAcceso.DeleteTipoVehiculo(id);
        }
    }
}
