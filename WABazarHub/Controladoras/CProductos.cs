using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WABazarHub.Comunicacion;
using WABazarHub.ServiceReference1;

namespace WABazarHub.Controladoras
{
    public class CProductos
    {
        private LNBazarHub lnBazarHub;
        public CProductos()
        {
            lnBazarHub = new LNBazarHub();
        }
        public void InsertarProducto(EProductos producto)
        {
            lnBazarHub.InsertarProducto(producto);
        }

        public void ActualizarProducto(EProductos producto)
        {
            lnBazarHub.ActualizarProducto(producto);
        }

        public void ActualizarEstadoProducto(int productoID, string estado)
        {
            lnBazarHub.ActualizarProductoEstado(productoID, estado);
        }

        public void ActualizarFechaEdicionProducto(int productoID, DateTime fechaEdicion)
        {
            lnBazarHub.ActualizarProductoFechaEdicion(productoID, fechaEdicion);
        }

        public List<EProductos> ObtenerTodosProductos()
        {
            return lnBazarHub.ObtenerTodosProductos();
        }

    }
}