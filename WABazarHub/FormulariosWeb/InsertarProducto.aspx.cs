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
    public partial class InsertarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCategorias();
                LoadProveedores();
            }
        }
        private void LoadCategorias()
        {
            CCategorias cCategorias = new CCategorias();
            ddlCategoria.DataSource = cCategorias.ObtenerTodasCategorias();
            ddlCategoria.DataTextField = "Nombre";
            ddlCategoria.DataValueField = "CategoriaID";
            ddlCategoria.DataBind();
            ddlCategoria.Items.Insert(0, new ListItem("-- Seleccione una Categoría --", "0"));
        }

        private void LoadProveedores()
        {
            CProvedores cProveedores = new CProvedores();
            ddlProveedor.DataSource = cProveedores.ObtenerTodosProveedores();
            ddlProveedor.DataTextField = "NombreEmpresa";
            ddlProveedor.DataValueField = "ProveedorID";
            ddlProveedor.DataBind();
            ddlProveedor.Items.Insert(0, new ListItem("-- Seleccione un Proveedor --", "0"));
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CProductos cProductos = new CProductos();
                EProductos nuevoProducto = new EProductos
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Precio = Convert.ToDecimal(txtPrecio.Text),
                    Stock = Convert.ToInt32(txtStock.Text),
                    CategoriaID = Convert.ToInt32(ddlCategoria.SelectedValue),
                    ProveedorID = Convert.ToInt32(ddlProveedor.SelectedValue),
                    Estado = "Activo",
                    FechaDeEdicion = DateTime.Now

                };

                cProductos.InsertarProducto(nuevoProducto);
                lblMensaje.Text = "Producto insertado correctamente.";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al insertar producto: " + ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}