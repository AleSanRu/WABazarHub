using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABazarHub.Controladoras;

namespace WABazarHub.FormulariosWeb
{
    public partial class AdministracionPedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView(); 
            }
        }

        private void BindGridView()
        {
            CPedidos cPedidos = new CPedidos();
            gvPedidos.DataSource = cPedidos.ObtenerTodosPedidos();
            gvPedidos.DataBind();
        }

        protected void gvPedidos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int pedidoID = Convert.ToInt32(e.CommandArgument);
            CPedidos cPedidos = new CPedidos();

            if (e.CommandName == "Edit")
            {
                Response.Redirect($"EditarPedido.aspx?PedidoID={pedidoID}"); 
            }
            else if (e.CommandName == "Cancelar")
            {
                cPedidos.ActualizarEstadoPedido(pedidoID, "Cancelado");
                BindGridView();
            }
        }

        protected void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarPedido.aspx"); 
        }
    }
}