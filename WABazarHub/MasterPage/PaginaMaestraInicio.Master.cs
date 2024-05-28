using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABazarHub.ServiceReference1;


namespace WABazarHub.MasterPage
{
    public partial class PaginaMaestraInicio : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            EUsuario usuarioSesion = Session["UsuarioSesion"] as EUsuario;
            if (usuarioSesion != null)
            {
                btnInicioSesion.Visible = false;
                btnCerrarSesion.Visible = true;
                lblCorreo.Text = usuarioSesion.Email;
                lblNombre.Text = usuarioSesion.Nombre;
                lblEstado.Text = usuarioSesion.Estado;

                Menu navigationMenu = (Menu)FindControl("NavigationMenu");

                if (usuarioSesion.TipoUsuarioID == 1)
                {
                    RemoveMenuItem(navigationMenu, "ComprasOnline");
                }
                else if (usuarioSesion.TipoUsuarioID == 2) 
                {
                    RemoveMenuItem(navigationMenu, "ComprasOnline/Administracion De Proveedores");
                }
                else if (usuarioSesion.TipoUsuarioID == 3) 
                {
                }
            }
            else
            {
                btnInicioSesion.Visible = true;
                btnCerrarSesion.Visible = false;

                lblCorreo.Text = "";
                lblNombre.Text = "";
                lblEstado.Text = "";
                Menu navigationMenu = (Menu)FindControl("NavigationMenu");
                RemoveMenuItem(navigationMenu, "ComprasOnline");
            }
        }

        private void RemoveMenuItem(Menu menu, string valuePath)
        {
            MenuItem itemToRemove = menu.FindItem(valuePath);
            if (itemToRemove != null && itemToRemove.Parent != null)
            {
                itemToRemove.Parent.ChildItems.Remove(itemToRemove);
            }
        }
        protected void btnInicioSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FormulariosWeb/InicioSesion.aspx"); 
            //mejoras correspondientes 
            //para la parte de diseño 

        }
      

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            // Lógica de checkout
        }
        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["UsuarioSesion"] = null;
        }
        protected void hlConfirmarPedido_Click(object sender, EventArgs e)
        {
            // Redirecciona a la página de confirmación de pedido
            Response.Redirect("~/FormulariosWeb/MostrarProductos.aspx");
        }
        protected void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            // Obtener el carrito de compras desde la sesión
            List<EProductos> cartItems = Session["CartItems"] as List<EProductos>;

            // Verificar si hay productos en el carrito
            if (cartItems == null || cartItems.Count == 0)
            {
                // Mostrar un mensaje si el carrito está vacío
                ScriptManager.RegisterStartupScript(this, GetType(), "mostrarMensajeCarritoVacio", "mostrarMensaje('El carrito está vacío.');", true);
            }
            else
            {
                // Almacenar los datos del carrito en caché
                Cache["CartItems"] = cartItems;

                // Redireccionar a la página de confirmación de pedido
                Response.Redirect("~/FormulariosWeb/ConfirmarPedido.aspx");
            }
        }
        private void MostrarMensaje(string mensaje)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", $"alert('{mensaje}');", true);
        }
    }
    

}