using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador.TipoVehiculo;

namespace Vista
{
    public partial class gestTipoVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);
            string typename = txtName.Text;

            logicaControladorTipoVehiculo negocioAddTipoVehiculo = new logicaControladorTipoVehiculo();

            int resultadoAddTipoVehiculo = negocioAddTipoVehiculo.NegociarInsertTipoVehiculo(cartypeid, typename);

            if (resultadoAddTipoVehiculo > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se pudo registrar";

            negocioAddTipoVehiculo = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorTipoVehiculo.NegociarSelectTipoVehiculo();

            GridView.DataBind();

            txtId.Text = txtName.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);
            string typename = txtName.Text;

            logicaControladorTipoVehiculo negocioUpdateTipoVehiculo = new logicaControladorTipoVehiculo();

            int resultadoUpdateTipoVehiculo = negocioUpdateTipoVehiculo.NegociarUpdateTipoVehiculo(cartypeid, typename);

            if (resultadoUpdateTipoVehiculo > 0)
                lblMensaje.Text = "Update ok";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateTipoVehiculo = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);

            logicaControladorTipoVehiculo negocioDeleteTipoVehiculo = new logicaControladorTipoVehiculo();

            int resultadoDeleteTipoVehiculo = negocioDeleteTipoVehiculo.NegociarDeleteTipoVehiculo(cartypeid);

            if (resultadoDeleteTipoVehiculo > 0)
                lblMensaje.Text = "Eliminar ok";
            else
                lblMensaje.Text = "No se pudo eliminar";

            negocioDeleteTipoVehiculo = null;
        }
    }
}