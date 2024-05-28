using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WABazarHub.FormulariosWeb
{
    public partial class Contactanos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string email = txtEmail.Text.Trim();
            string asunto = txtAsunto.Text.Trim();
            string mensaje = txtMensaje.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(asunto) || string.IsNullOrEmpty(mensaje))
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "Por favor, completa todos los campos.";
                return;
            }

            if (!IsValidEmail(email))
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "Por favor, ingresa un correo electrónico válido.";
                return;
            }

            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("bazarhubonline@gmail.com"),
                    Subject = asunto,
                    Body = $"Nombre: {nombre}\nEmail: {email}\nMensaje: {mensaje}"
                };
                mail.To.Add("bazarhubonline@gmail.com");

                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
                {
                    smtpClient.Port = 587; 
                    smtpClient.Credentials = new System.Net.NetworkCredential("bazarhubonline@gmail.com", "nnvj jqcu anpn nqyr"); // Usa la contraseña de aplicación aquí
                    smtpClient.EnableSsl = true;

                    smtpClient.Send(mail);
                }

                lblMensaje.ForeColor = System.Drawing.Color.Green;
                lblMensaje.Text = "Tu recomendación ha sido enviada con éxito.";
            }
            catch (SmtpException smtpEx)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = $"Error al enviar el correo: {smtpEx.Message}";
            }
            catch (Exception ex)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = $"Ocurrió un error: {ex.Message}";
            }
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}