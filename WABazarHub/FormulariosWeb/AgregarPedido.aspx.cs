using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABazarHub.Controladoras;
using WABazarHub.ServiceReference1;

namespace WABazarHub.FormulariosWeb
{
    public partial class AgregarPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadUsuarios();
            }
        }

        private void LoadUsuarios()
        {
            CUsuarios cUsuarios = new CUsuarios();
            ddlUsuario.DataSource = cUsuarios.ObtenerTodosUsuarios();
            ddlUsuario.DataTextField = "Nombre";  // Assuming 'Nombre' is what you want to show
            ddlUsuario.DataValueField = "UsuarioID";
            ddlUsuario.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            CPedidos cPedidos = new CPedidos();
            cPedidos.InsertarPedido(new EPedidos
            {
                UsuarioID = int.Parse(ddlUsuario.SelectedValue),
                FechaPedido = calFechaPedido.SelectedDate,
                Estado = "Pendiente", 
                DireccionEnvio = txtDireccionEnvio.Text,
                FechaDeEdicion = DateTime.Now
            });

            Response.Redirect("AdministracionPedidos.aspx");
        }
    }
}