using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador.Contrato;

namespace Vista
{
    public partial class gestContrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int idruta = Int32.Parse(txtId.Text);
            int id_conductor = Int32.Parse(txtId_conductor.Text);
            int id_vehiculo = Int32.Parse(txtId_vehiculo.Text);

            logicaControladorContrato negocioAddContrato = new logicaControladorContrato();

            int resultadoContrato = negocioAddContrato.NegociarInsertContrato(idruta, id_conductor, id_vehiculo);

            if (resultadoContrato > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se pudo registrar";

            negocioAddContrato = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorContrato.NegociarSelectContrato();

            GridView.DataBind();

            txtId.Text = txtId_conductor.Text = txtId_vehiculo.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int idruta = Int32.Parse(txtId.Text);
            int id_conductor = Int32.Parse(txtId_conductor.Text);
            int id_vehiculo = Int32.Parse(txtId_vehiculo.Text);

            logicaControladorContrato negocioUpdateContrato = new logicaControladorContrato();

            int resultadoContrato = negocioUpdateContrato.NegociarUpdatetContrato(idruta, id_conductor, id_vehiculo);

            if (resultadoContrato > 0)
                lblMensaje.Text = "Actualizado";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateContrato = null;
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            int idruta = Int32.Parse(txtId.Text);

            logicaControladorContrato negocioDeleteContrato = new logicaControladorContrato();

            int resultadoContrato = negocioDeleteContrato.NegociarDeleteContrato(idruta);

            if (resultadoContrato > 0)
                lblMensaje.Text = "Eliminado";
            else
                lblMensaje.Text = "No se pudo eliminar";

            negocioDeleteContrato = null;
        }
    }
}