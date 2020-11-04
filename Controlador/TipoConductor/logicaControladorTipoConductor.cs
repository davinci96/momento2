using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.TipoConductor;

namespace Controlador.TipoConductor
{
    public class logicaControladorTipoConductor
    {
        //negociar INSERT
        public int NegociarTipoConductor(int id, string tipo_persona)
        {
             AccesoMetodosCRUDTipoConductor acceso = new AccesoMetodosCRUDTipoConductor();

            return acceso.InsertTipoConductor(id, tipo_persona);
        }

        //negociar select
        public static DataTable NegociarSelectTipoConductor()
        {
            return AccesoMetodosCRUDTipoConductor.ListTipoConductor();
        }

        //negociar update
        public int NegociarUpdateTipoConductor(int id, string name)
        {
            AccesoMetodosCRUDTipoConductor negociarAcceso = new AccesoMetodosCRUDTipoConductor();

            return negociarAcceso.UpdatetTipoConductor(id, name);
        }

        //negociar delete
        public int NegociarDeleteTipoConductor(int id)
        {
            AccesoMetodosCRUDTipoConductor negociarAcceso = new AccesoMetodosCRUDTipoConductor();

            return negociarAcceso.DeleteTipoConductor(id);
        }
    }
}
