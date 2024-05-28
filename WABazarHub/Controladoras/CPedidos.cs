using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WABazarHub.Comunicacion;
using WABazarHub.ServiceReference1;

namespace WABazarHub.Controladoras
{
    public class CPedidos
    {
        private LNBazarHub lnBazarHub;
        public CPedidos()
        {
            lnBazarHub = new LNBazarHub();
        }
        public void InsertarPedido(EPedidos pedido)
        {
            lnBazarHub.InsertarPedido(pedido);
        }

        public void ActualizarPedido(EPedidos pedido)
        {
            lnBazarHub.ActualizarPedido(pedido);
        }

        public void ActualizarEstadoPedido(int pedidoID, string estado)
        {
            lnBazarHub.ActualizarPedidoEstado(pedidoID, estado);
        }

        public void ActualizarFechaEdicionPedido(int pedidoID, DateTime fechaEdicion)
        {
            lnBazarHub.ActualizarPedidoFechaEdicion(pedidoID, fechaEdicion);
        }

        public List<EPedidos> ObtenerTodosPedidos()
        {
            return lnBazarHub.ObtenerTodosPedidos();
        }
    }
}