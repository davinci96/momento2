using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador.TipoConductor;

namespace Vista
{
    public partial class gestTipoConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int idtipoConductor = Int32.Parse(txtId.Text);
            string tipopersona = txtTipoPersona.Text;

            logicaControladorTipoConductor negocioAddTipoConductor = new logicaControladorTipoConductor();

            int resultadoTipoConductor = negocioAddTipoConductor.NegociarTipoConductor(idtipoConductor, tipopersona);

            if (resultadoTipoConductor > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se pudo resgistrar";

            negocioAddTipoConductor = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorTipoConductor.NegociarSelectTipoConductor();

            GridView.DataBind();

            txtId.Text = txtTipoPersona.Text  = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int idtipoConductor = Int32.Parse(txtId.Text);
            string tipopersona = txtTipoPersona.Text;

            logicaControladorTipoConductor negocioUpdateTipoConductor = new logicaControladorTipoConductor();

            int resultadoTipoConductor = negocioUpdateTipoConductor.NegociarUpdateTipoConductor(idtipoConductor, tipopersona);

            if (resultadoTipoConductor > 0)
                lblMensaje.Text = "Actualizado";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateTipoConductor = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int idtipoConductor = Int32.Parse(txtId.Text);
            

            logicaControladorTipoConductor negocioDeleteTipoConductor = new logicaControladorTipoConductor();

            int resultadoTipoConductor = negocioDeleteTipoConductor.NegociarDeleteTipoConductor(idtipoConductor);

            if (resultadoTipoConductor > 0)
                lblMensaje.Text = "Eliminado";
            else
                lblMensaje.Text = "No se pudo Eliminar";

            negocioDeleteTipoConductor = null;
        }
    }
}