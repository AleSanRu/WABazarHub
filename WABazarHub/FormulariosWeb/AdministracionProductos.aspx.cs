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
    public partial class AdministracionProductos : System.Web.UI.Page
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
            CProductos cProductos = new CProductos();
            gvProductos.DataSource = cProductos.ObtenerTodosProductos();
            gvProductos.DataBind();
        }

        protected void gvProductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                int productoID = Convert.ToInt32(e.CommandArgument);
                Response.Redirect($"EditarProducto.aspx?ProductoID={productoID}");
            }
            else if (e.CommandName == "Cancelar")
            {
                int productoID = Convert.ToInt32(e.CommandArgument);
                CProductos cProductos = new CProductos();
                cProductos.ActualizarEstadoProducto(productoID, "Inactivo");
                cProductos.ActualizarFechaEdicionProducto(productoID,DateTime.Now);
                BindGridView();
            }
        }

        protected void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertarProducto.aspx");
        }
    }
}