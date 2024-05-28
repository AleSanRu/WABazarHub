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
    public partial class EditarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ProductoID"] != null)
                {
                    int productoID = int.Parse(Request.QueryString["ProductoID"]);
                    BindDetailsView(productoID);
                }
                else
                {
                    Response.Redirect("AdministracionProductos.aspx");
                }
            }
        }
        private void BindDetailsView(int productoID)
        {
            CProductos cProductos = new CProductos();
            var producto = cProductos.ObtenerTodosProductos().Find(p => p.ProductoID == productoID);
            List<EProductos> listaProducto = new List<EProductos> { producto };
            dvProducto.DataSource = listaProducto;
            dvProducto.DataBind();
        }

        protected void dvProducto_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
        {
            CProductos cProductos = new CProductos();
            EProductos producto = new EProductos
            {
                ProductoID = Convert.ToInt32(e.Keys["ProductoID"]),
                Nombre = e.NewValues["Nombre"].ToString(),
                Descripcion = e.NewValues["Descripcion"].ToString(),
                Precio = Decimal.Parse(e.NewValues["Precio"].ToString()),
                Stock = Convert.ToInt32(e.NewValues["Stock"]),
                FechaDeEdicion = DateTime.Now
                
            };

            cProductos.ActualizarProducto(producto);
            dvProducto.ChangeMode(DetailsViewMode.ReadOnly);
            BindDetailsView(producto.ProductoID);
            Response.Redirect("AdministracionProductos.aspx");
        }
        protected void btnRegresarProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdministracionProductos.aspx");
        }
    }
}