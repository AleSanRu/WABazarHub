using System;
using System.Collections.Generic;
using System.Drawing;
using QRCoder;
using WABazarHub.ServiceReference1;

namespace WABazarHub.FormulariosWeb
{
    public partial class ComprarPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Recuperar elementosPedido de la sesión
            var elementosPedido = Session["ElementosPedido"] as List<EProductos>;

            // Verificar si elementosPedido no es nulo y calcular el monto total
            if (elementosPedido != null)
            {
                decimal montoTotal = CalcularMontoTotal(elementosPedido);

                // Luego, puedes usar el montoTotal para generar el código QR
                GenerarCodigoQR(montoTotal);

                // Generar la lista de productos en forma de texto
                string listaProductos = GenerarListaProductos(elementosPedido, montoTotal);

                // Asignar la lista de productos al Literal
                litProductos.Text = listaProductos;
            }
        }

        // Método para calcular el monto total de los productos
        private decimal CalcularMontoTotal(List<EProductos> elementosPedido)
        {
            decimal montoTotal = 0.0m;

            // Recorre la lista de productos seleccionados y suma sus precios al monto total
            foreach (var producto in elementosPedido)
            {
                montoTotal += producto.Precio;
            }

            return montoTotal;
        }

        // Método para generar el código QR
        private void GenerarCodigoQR(decimal montoTotal)
        {
            // Crear el contenido del código QR
            string qrContent = montoTotal.ToString();

            // Crear el generador de códigos QR
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrContent, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            // Renderizar el código QR como un objeto Bitmap
            Bitmap qrCodeImage = qrCode.GetGraphic(20); // El segundo parámetro es el tamaño del código QR

            // Mostrar el código QR en una Image control llamada imgQR
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                qrCodeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] byteImage = ms.ToArray();
                imgQR.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);
            }
        }
        private string GenerarListaProductos(List<EProductos> elementosPedido, decimal montoTotal)
        {
            string listaProductos = "<ul>";

            // Recorrer la lista de productos y agregar cada uno a la lista
            foreach (var producto in elementosPedido)
            {
                listaProductos += "<li>" + producto.Nombre + ": $" + producto.Precio.ToString() + "</li>";
            }

            listaProductos += "</ul>";

            // Agregar el precio total al final de la lista
            listaProductos += "<p>Total: $" + montoTotal.ToString() + "</p>";

            return listaProductos;
        }
    }
}
