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
    public partial class EditarProvedor : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ProveedorID"] != null)
                {
                    int proveedorID = int.Parse(Request.QueryString["ProveedorID"]);
                    BindDetailsView(proveedorID);
                }
                else
                {
                    Response.Redirect("AdministracionProveedores.aspx");
                }
            }
        }

        private void BindDetailsView(int proveedorID)
        {
            CProvedores cProveedores = new CProvedores();
            var provedore = cProveedores.ObtenerTodosProveedores().Find(p => p.ProveedorID == proveedorID);
            List<EProveedores> listaProducto = new List<EProveedores> { provedore };
            dvProveedor.DataSource = listaProducto;
            dvProveedor.DataBind();
        }

        protected void dvProveedor_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
        {
            CProvedores cProveedores = new CProvedores();
            EProveedores proveedor = new EProveedores
            {
                ProveedorID = Convert.ToInt32(e.Keys["ProveedorID"]),
                NombreEmpresa = e.NewValues["NombreEmpresa"].ToString(),
                Contacto = e.NewValues["Contacto"].ToString(),
                Email = e.NewValues["Email"].ToString(),
                Estado = e.NewValues["Estado"].ToString(),
                FechaDeEdicion = DateTime.Now
            };

            cProveedores.ActualizarProveedor(proveedor);
            dvProveedor.ChangeMode(DetailsViewMode.ReadOnly);
            BindDetailsView(proveedor.ProveedorID);
            Response.Redirect("AdministracionProveedores.aspx");
        }

        protected void btnRegresarProveedor_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdministracionProveedores.aspx");
        }
    }
}