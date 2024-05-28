using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABazarHub.ServiceReference1;

namespace WABazarHub.FormulariosWeb
{
    public partial class ConfirmarPedido : System.Web.UI.Page
    {
        private List<EProductos> elementosPedido = new List<EProductos>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Recuperar los datos del carrito de la sesión
                var cartItems = Session["CartItems"] as List<EProductos>;

                if (cartItems != null && cartItems.Count > 0)
                {
                    // Vincular los datos al control Repeater
                        rptProductosSeleccionados.DataSource = cartItems;
                        rptProductosSeleccionados.DataBind();
                }
                else
                {
                    // Si no hay productos en el carrito, redirigir a la página de inicio u otra página apropiada
                    Response.Redirect("~/Inicio.aspx");
                }
            }
        }

        protected void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            // Supongamos que tienes una lista de productos seleccionados en Session["CartItems"]
            var cartItems = Session["CartItems"] as List<EProductos>;

            // Verifica que la lista de productos seleccionados no sea nula
            if (cartItems != null)
            {
                // Agrega los productos seleccionados a la lista de elementos del pedido
                elementosPedido.AddRange(cartItems);

                // Limpia la sesión después de guardar los elementos en la lista en memoria
                Session.Remove("CartItems");
            }
            Session["ElementosPedido"] = elementosPedido;
            // Después de confirmar el pedido y guardar los elementos, puedes redirigir a una página de confirmación o a la página de inicio
            Response.Redirect("../FormulariosWeb/ComprarPedido.aspx");
        }

        protected void btnEliminar_Command(object sender, CommandEventArgs e)
        {
            var cartItems = Session["CartItems"] as List<EProductos>;
            if (e.CommandName == "Eliminar")
            {
                // Obtén el ID del elemento a eliminar
                int id = Convert.ToInt32(e.CommandArgument);

                // Encuentra el elemento en la lista cartItems y elimínalo
                var itemToRemove = cartItems.FirstOrDefault(item => item.CategoriaID == id);
                if (itemToRemove != null)
                {
                    cartItems.Remove(itemToRemove);

                    // Vuelve a hacer el databinding para reflejar los cambios
                    rptProductosSeleccionados.DataSource = cartItems;
                    rptProductosSeleccionados.DataBind();
                }
            }
        }
       
    }
}