using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABazarHub.Controladoras;
using WABazarHub.ServiceReference1;

namespace WABazarHub.FormulariosWeb
{
    public partial class EditarPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["PedidoID"] != null)
                {
                    int pedidoID = int.Parse(Request.QueryString["PedidoID"]);
                    BindDetailsView(pedidoID);
                }
                else
                {
                    Response.Redirect("AdministracionPedidos.aspx");
                }
            }
        }

        private void BindDetailsView(int pedidoID)
        {
            CPedidos cPedidos = new CPedidos();
            var pedido = cPedidos.ObtenerTodosPedidos().Find(p => p.PedidoID == pedidoID);
            List<EPedidos> listaPedidos = new List<EPedidos> { pedido };
            dvPedido.DataSource = listaPedidos;
            dvPedido.DataBind();
        }

        protected void dvPedido_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
        {
            CPedidos cPedidos = new CPedidos();
            EPedidos pedido = new EPedidos
            {
                PedidoID = Convert.ToInt32(e.Keys["PedidoID"]),
                UsuarioID = Convert.ToInt32(e.Keys["UsuarioID"]),
                FechaPedido = Convert.ToDateTime(e.NewValues["FechaPedido"]),
                DireccionEnvio = e.NewValues["DireccionEnvio"].ToString(),
                Estado = e.NewValues["Estado"].ToString(),
                FechaDeEdicion = DateTime.Now
            };

            cPedidos.ActualizarPedido(pedido);
            dvPedido.ChangeMode(DetailsViewMode.ReadOnly);
            BindDetailsView(pedido.PedidoID);
            Response.Redirect("AdministracionPedidos.aspx");
        }
    }
}