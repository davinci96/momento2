using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador.Conductor;

namespace Vista
{
    public partial class gestConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int idConductor = Int32.Parse(txtId.Text);
            string nombreconductor = txtNombre.Text;
            string tipolicencia = txtTipoLicencia.Text;
            int idvehiculo = Int32.Parse(IdVehiculo.Text);
            int idtipoconductor = Int32.Parse(IdTipoConductor.Text);

            logicaConductor negocioAddConductor = new logicaConductor();

            int resultadoAddConductor = negocioAddConductor.NegociarInsertConductor(idConductor, nombreconductor, tipolicencia, idvehiculo, idtipoconductor);

            if (resultadoAddConductor > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se pudo resgistrar";

            negocioAddConductor = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource =logicaConductor.NegociarSelectConductor();

            GridView.DataBind();

            txtId.Text = txtNombre.Text = txtTipoLicencia.Text = IdVehiculo.Text = IdTipoConductor.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int idConductor = Int32.Parse(txtId.Text);
            string nombreconductor = txtNombre.Text;
            string tipolicencia = txtTipoLicencia.Text;
            int idvehiculo = Int32.Parse(IdVehiculo.Text);
            int idtipoconductor = Int32.Parse(IdTipoConductor.Text);

            logicaConductor negocioUpdateConductor = new logicaConductor();

            int resultadoUpdateConductor = negocioUpdateConductor.NegociarUpdateConductor(idConductor, nombreconductor, tipolicencia, idvehiculo, idtipoconductor);

            if (resultadoUpdateConductor > 0)
                lblMensaje.Text = "Actualizado";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateConductor = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int idConductor = Int32.Parse(txtId.Text);

            logicaConductor negocioDeleteConductor = new logicaConductor();

            int resultadoDeleteConductor = negocioDeleteConductor.NegociarDeleteConductor(idConductor);

            if (resultadoDeleteConductor > 0)
                lblMensaje.Text = "Eliminado";
            else
                lblMensaje.Text = "No se pudo Eliminar";

            negocioDeleteConductor = null;
        }
    }
}