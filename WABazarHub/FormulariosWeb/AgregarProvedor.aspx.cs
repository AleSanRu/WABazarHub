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
    public partial class AgregarProvedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CProvedores cProveedores = new CProvedores();

                EProveedores nuevoProveedor = new EProveedores
                {
                    NombreEmpresa = txtNombreEmpresa.Text.Trim(),
                    Contacto = txtContacto.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Estado = "Activo",
                    FechaDeEdicion = DateTime.Now
                };

                cProveedores.InsertarProveedor(nuevoProveedor);

                lblMensaje.Text = "Proveedor insertado correctamente.";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al insertar proveedor: " + ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}