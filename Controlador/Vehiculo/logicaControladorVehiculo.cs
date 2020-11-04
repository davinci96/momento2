using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.TipoVehiculo;
using Modelo.Vehiculo;

namespace Controlador.Vehiculo
{
    public class logicaControladorVehiculo
    {
        //negociar INSERT
        public int NegociarInsertVehiculo(int id, string marca, string modelo, string placa, int anio, int id_tv)
        {
            AccesoMetodosCRUDVehiculo acceso = new AccesoMetodosCRUDVehiculo();

            return acceso.InsertVehiculo(id, marca, modelo, placa, anio, id_tv);
        }

        //negociar select
        public static DataTable NegociarSelectVehiculo()
        {
            return AccesoMetodosCRUDVehiculo.ListtVehiculo();
        }

        //negociar UPDATE
        public int NegociarUpdateVehiculo(int id, string marca, string modelo, string placa, int anio, int id_tv)
        {
            AccesoMetodosCRUDVehiculo acceso = new AccesoMetodosCRUDVehiculo();

            return acceso.UpdateVehiculo(id, marca, modelo, placa, anio, id_tv);
        }

        //negociar DELETE
        public int NegociarDeleteVehiculo(int id)
        {
            AccesoMetodosCRUDVehiculo acceso = new AccesoMetodosCRUDVehiculo();

            return acceso.DeleteVehiculo(id);
        }
    }
}
