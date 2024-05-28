using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABazarHub.Comunicacion;
using WABazarHub.Controladoras;
using WABazarHub.ServiceReference1;

namespace WABazarHub.FormulariosWeb
{
    public partial class MostrarProductos : System.Web.UI.Page
    {
        private CProductos cProductos;
        private List<EProductos> cartItems;

        protected void Page_Load(object sender, EventArgs e)
        {
            cProductos = new CProductos();
            cartItems = Session["CartItems"] as List<EProductos> ?? new List<EProductos>();

            if (!IsPostBack)
            {
                CargarProductos();
            }
            if (Session["scrollPosition"] != null)
            {
                // Restaurar la posición de la página después de cargarla
                string script = "window.scrollTo(0, " + Session["scrollPosition"] + ");";
                ScriptManager.RegisterStartupScript(this, GetType(), "RestaurarPosicion", script, true);
            }


            // Actualizar el carrito en cada carga de página
            UpdateCart();
        }

        private void CargarProductos()
        {
            try
            {
                List<EProductos> productos = cProductos.ObtenerTodosProductos();
                if (productos != null && productos.Count > 0)
                {
                    rptProductos.DataSource = productos;
                    rptProductos.DataBind();
                }
                else
                {
                    lblMensaje.Text = "No se encontraron productos.";
                    lblMensaje.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al cargar los productos: " + ex.Message;
                lblMensaje.Visible = true;
            }
        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            Button btnSumar = (Button)sender;
            int productId = Convert.ToInt32(btnSumar.CommandArgument);
            EProductos productToAddToCart = ObtenerProductoPorId(productId);
            AddProductToCart(productToAddToCart);
            ScriptManager.RegisterStartupScript(this, GetType(), "GuardarPosicion", "guardarPosicion();", true);
            // Actualizar la página después de agregar un producto al carrito
            Response.Redirect(Request.RawUrl);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Button btnEliminar = (Button)sender;
            int productId = Convert.ToInt32(btnEliminar.CommandArgument);
            RemoveProductFromCart(productId);
        }

        private void AddProductToCart(EProductos product)
        {
            List<EProductos> cartItems = Session["CartItems"] as List<EProductos> ?? new List<EProductos>();
            cartItems.Add(product);
            Session["CartItems"] = cartItems;
            UpdateCart();
        }

        private void RemoveProductFromCart(int productId)
        {
            List<EProductos> cartItems = Session["CartItems"] as List<EProductos> ?? new List<EProductos>();
            EProductos productToRemove = cartItems.FirstOrDefault(p => p.ProductoID == productId);
            if (productToRemove != null)
            {
                cartItems.Remove(productToRemove);
                Session["CartItems"] = cartItems;
                UpdateCart();
            }
        }

        protected string GetImagePath(object productID)
        {
            int id;
            if (int.TryParse(productID.ToString(), out id))
            {
                string[] imageFiles = Directory.GetFiles(Server.MapPath("/Imagenes/"), id + ".*");

                foreach (string filePath in imageFiles)
                {
                    string extension = Path.GetExtension(filePath).ToLower();
                    if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif")
                    {
                        return "/Imagenes/" + Path.GetFileName(filePath);
                    }
                }
            }

            return "/Imagenes/IMGBazar.jpg";
        }

        private EProductos ObtenerProductoPorId(int productId)
        {
            CProductos cProductos = new CProductos();
            List<EProductos> productos = cProductos.ObtenerTodosProductos();
            EProductos producto = productos.FirstOrDefault(p => p.ProductoID == productId);

            return producto;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtBuscarProductos.Text.Trim();
            decimal costoMinimo = 0;
            decimal costoMaximo = decimal.MaxValue; 
            if (!string.IsNullOrEmpty(txtCostoMinimo.Text))
            {
                costoMinimo = decimal.Parse(txtCostoMinimo.Text);
            }
            if (!string.IsNullOrEmpty(txtCostoMaximo.Text))
            {
                costoMaximo = decimal.Parse(txtCostoMaximo.Text);
            }
            string nombreProveedor = txtProveedor.Text.Trim();

            List<EProductos> productosFiltrados = BuscarProductos(nombreProducto, costoMinimo, costoMaximo);

            rptProductos.DataSource = productosFiltrados;
            rptProductos.DataBind();
        }
        private List<EProductos> BuscarProductos(string nombreProducto, decimal costoMinimo, decimal costoMaximo)
        {

            List<EProductos> todosProductos = cProductos.ObtenerTodosProductos();
            List<EProductos> productosFiltrados = todosProductos.Where(p =>
                (string.IsNullOrEmpty(nombreProducto) || p.Nombre.Contains(nombreProducto)) && // Filtrar por nombre del producto
                (costoMinimo <= 0 || p.Precio >= costoMinimo) && // Filtrar por costo mínimo
                (costoMaximo <= 0 || p.Precio <= costoMaximo) // Filtrar por costo máximo
            ).ToList();

            return productosFiltrados;
        }
        private void UpdateCart()
        {
            Repeater rptMasterCartItems = (Repeater)Master.FindControl("rptCartItems");
            Label lblMasterCartTotal = (Label)Master.FindControl("lblCartTotal");

            if (rptMasterCartItems != null && lblMasterCartTotal != null)
            {
            
                rptMasterCartItems.DataSource = cartItems;
                rptMasterCartItems.DataBind();

             
                decimal total = 0;
                foreach (var item in cartItems)
                {
                    total += item.Precio;
                }
                lblMasterCartTotal.Text = total.ToString("C");
            }
            else
            {
                // Manejar el caso en el que no se encontraron los controles del maestro
                // Esto puede ser útil para depuración o para manejar errores
                // Por ejemplo, puedes mostrar un mensaje de error o tomar otra acción apropiada
            }
        }
    }
}
    