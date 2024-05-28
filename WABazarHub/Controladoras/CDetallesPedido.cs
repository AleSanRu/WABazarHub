using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WABazarHub.Comunicacion;
using WABazarHub.ServiceReference1;

namespace WABazarHub.Controladoras
{
    public class CDetallesPedido
    {
        private LNBazarHub lnBazarHub;
        public CDetallesPedido()
        {
            lnBazarHub = new LNBazarHub();
        }
        public void InsertarDetallePedido(EDetallesPedido detallePedido)
        {
            lnBazarHub.InsertarDetallePedido(detallePedido);
        }

        public void ActualizarDetallePedido(EDetallesPedido detallePedido)
        {
            lnBazarHub.ActualizarDetallePedido(detallePedido);
        }

        public void ActualizarEstadoDetallePedido(int detalleID, string estado)
        {
            lnBazarHub.ActualizarDetallePedidoEstado(detalleID, estado);
        }

        public void ActualizarFechaEdicionDetallePedido(int detalleID, DateTime fechaEdicion)
        {
            lnBazarHub.ActualizarDetallePedidoFechaEdicion(detalleID, fechaEdicion);
        }

        public List<EDetallesPedido> ObtenerTodosDetallesPedidos()
        {
            return lnBazarHub.ObtenerTodosDetallesPedidos();
        }
    }
}