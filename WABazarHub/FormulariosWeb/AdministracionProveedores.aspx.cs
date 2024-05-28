using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABazarHub.Controladoras;

namespace WABazarHub.FormulariosWeb
{
    public partial class AdministracionProveedores : System.Web.UI.Page
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
            CProvedores cProveedores = new CProvedores();
            gvProveedores.DataSource = cProveedores.ObtenerTodosProveedores();
            gvProveedores.DataBind();
        }

        protected void gvProveedores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                int proveedorID = Convert.ToInt32(e.CommandArgument);
                Response.Redirect($"EditarProvedor.aspx?ProveedorID={proveedorID}");
            }
            else if (e.CommandName == "Eliminar")
            {
                int proveedorID = Convert.ToInt32(e.CommandArgument);
                CProvedores cProveedores = new CProvedores();
                cProveedores.ActualizarEstadoProveedor(proveedorID,"Inactivo");
                BindGridView();
            }
        }

        protected void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarProvedor.aspx");
        }
    }
}