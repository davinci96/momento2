using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador.Ruta;

namespace Vista
{
    public partial class gestRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int idruta = Int32.Parse(txtId.Text);
            string estacion = txtestacion.Text;
            int id_vehiculo = Int32.Parse(txtId_vehiculo.Text);

            logicaControladorRuta negocioAddRuta = new logicaControladorRuta();

            int resultadoRuta = negocioAddRuta.NegociarInsertRuta(idruta, estacion, id_vehiculo);

            if (resultadoRuta > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se pudo registrar";

            negocioAddRuta =null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource= logicaControladorRuta.NegociarSelectRuta();

            GridView.DataBind();

            txtId.Text = txtestacion.Text = txtId_vehiculo.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int idruta = Int32.Parse(txtId.Text);
            string estacion = txtestacion.Text;
            int id_vehiculo = Int32.Parse(txtId_vehiculo.Text);

            logicaControladorRuta negocioUpdateRuta = new logicaControladorRuta();

            int resultadoRuta = negocioUpdateRuta.NegociarUpdateRuta(idruta, estacion, id_vehiculo);

            if (resultadoRuta > 0)
                lblMensaje.Text = "Actualizado";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateRuta = null;
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            int idruta = Int32.Parse(txtId.Text);

            logicaControladorRuta negocioDeleteRuta = new logicaControladorRuta();

            int resultadoRuta = negocioDeleteRuta.NegociarDeleteRuta(idruta);

            if (resultadoRuta > 0)
                lblMensaje.Text = "Eliminado";
            else
                lblMensaje.Text = "No se pudo eliminar";

            negocioDeleteRuta = null;
        }
    }
}