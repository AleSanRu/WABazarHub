using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Net.Mail;
using Microsoft.IdentityModel.Tokens;
using WABazarHub.Controladoras;
using WABazarHub.ServiceReference1;

namespace WABazarHub.FormulariosWeb
{
    public partial class InicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string captcha = GenerarCaptcha();
                Session["Captcha"] = captcha;
                lblCaptcha.Text = "CAPTCHA: " + captcha;
            }
        }

        public string GenerarClaveSecreta()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[32];
                rng.GetBytes(randomBytes);
                return Convert.ToBase64String(randomBytes);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtPassword.Text;
            CUsuarios cUsuarios = new CUsuarios();
            var (existe, Usuario) = cUsuarios.InicioSesion(nombreUsuario, contraseña);

            if (existe)
            {
                Session["UsuarioSesion"] = Usuario as EUsuario;
                string captchaGenerado = Session["Captcha"] as string;
                string captchaIngresado = txtCaptcha.Text;

                if (captchaGenerado == captchaIngresado)
                {

                    string correoUsuario = Usuario.Email; 
                    string codigoAuth = GenerarCodigoAutenticacion();
                    Session["CodigoAuth"] = codigoAuth;
                    EnviarCodigoAutenticacionPorCorreo(correoUsuario, codigoAuth);

                    authPanel.Visible = true;
                    loginPanel.Visible = false;
                    captchaPanel.Visible = false;
                }
                else
                {
                    string captcha = GenerarCaptcha();
                    Session["Captcha"] = captcha;
                    lblCaptcha.Text = "CAPTCHA: " + captcha;
                    MostrarAlerta("El CAPTCHA ingresado es incorrecto.", "alert-danger");
                }
            }
            else
            {
                MostrarAlerta("Nombre de usuario o contraseña incorrectos.", "alert-danger");
            }
        }

        protected string GenerarCodigoAutenticacion()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static readonly Random random = new Random();
        protected string GenerarCaptcha()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        protected void lnkRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroUsuario.aspx");
        }

        protected void btnAuth_Click(object sender, EventArgs e)
        {
            string codigoAuthGenerado = Session["CodigoAuth"] as string;
            string codigoAuthIngresado = txtAuthCode.Text;

            if (codigoAuthGenerado == codigoAuthIngresado)
            {
                Response.Redirect("PaginaInicio.aspx");
            }
            else
            {
                lblMensaje.Text = "El código de autenticación ingresado es incorrecto.";
            }
        }

        protected void EnviarCodigoAutenticacionPorCorreo(string correoUsuario, string codigo)
        {
            string remitente = "bazarhubonline@gmail.com"; 
            string asunto = "Código de autenticación";
            string cuerpo = "Tu código de autenticación es: " + codigo;

            MailMessage mensaje = new MailMessage(remitente, correoUsuario, asunto, cuerpo);

            try
            {
                string smtpHost = "smtp.gmail.com";
                int smtpPort = 587; 
                string smtpUsuario = "bazarhubonline@gmail.com";
                string smtpPassword = "nnvj jqcu anpn nqyr"; 


                SmtpClient client = new SmtpClient(smtpHost, smtpPort);
                client.EnableSsl = true; 
                client.Credentials = new NetworkCredential(smtpUsuario, smtpPassword);

                client.Send(mensaje);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo electrónico: " + ex.Message);
            }
        }
        private void MostrarAlerta(string mensaje, string claseCSS)
        {
            alertMessage.Text = mensaje;
            alertPanel.CssClass = "alert " + claseCSS + " alert-dismissible fade show";
            alertPanel.Visible = true;
        }
    }
}