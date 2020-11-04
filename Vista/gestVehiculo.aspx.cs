using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador.Vehiculo;

namespace Vista
{
    public partial class gestVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int idvehiculo = Int32.Parse(txtId.Text);
            string marcavehiculo = TxtMarca.Text;
            string modelovehiculo = TxtModelo.Text;
            string placavehiculo = TxtPlaca.Text;
            int aniovehiculo = Int32.Parse(TxtAnio.Text);
            int id_tvehiculo = Int32.Parse(TxtId_tv.Text);

            logicaControladorVehiculo negocioAddVehiculo = new logicaControladorVehiculo();

            int resultadoAddVehiculo = negocioAddVehiculo.NegociarInsertVehiculo(idvehiculo,marcavehiculo,modelovehiculo,placavehiculo,aniovehiculo,id_tvehiculo);

            if (resultadoAddVehiculo > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se pudo resgistrar";

            negocioAddVehiculo = null;
        }

        protected void btnlist_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorVehiculo.NegociarSelectVehiculo();

            GridView.DataBind();

            txtId.Text = TxtMarca.Text = TxtModelo.Text = TxtPlaca.Text = TxtAnio.Text = TxtId_tv.Text = "";

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int idvehiculo = Int32.Parse(txtId.Text);
            string marcavehiculo = TxtMarca.Text;
            string modelovehiculo = TxtModelo.Text;
            string placavehiculo = TxtPlaca.Text;
            int aniovehiculo = Int32.Parse(TxtAnio.Text);
            int id_tvehiculo = Int32.Parse(TxtId_tv.Text);

            logicaControladorVehiculo negocioUpdateVehiculo = new logicaControladorVehiculo();

            int resultadoUpdateVehiculo = negocioUpdateVehiculo.NegociarUpdateVehiculo(idvehiculo, marcavehiculo, modelovehiculo, placavehiculo, aniovehiculo, id_tvehiculo);

            if (resultadoUpdateVehiculo > 0)
                lblMensaje.Text = "Update ok";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateVehiculo = null;
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            int idvehiculo = Int32.Parse(txtId.Text);

            logicaControladorVehiculo negocioDeleteVehiculo = new logicaControladorVehiculo();

            int resultadoDeleteVehiculo = negocioDeleteVehiculo.NegociarDeleteVehiculo(idvehiculo);

            if (resultadoDeleteVehiculo > 0)
                lblMensaje.Text = "Delete ok";
            else
                lblMensaje.Text = "No se pudo eliminar";

            negocioDeleteVehiculo = null;
        }
    }
}