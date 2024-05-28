using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WABazarHub.Comunicacion;
using WABazarHub.ServiceReference1;

namespace WABazarHub.Controladoras
{
    public class CProvedores
    {
        private LNBazarHub lnBazarHub;
        public CProvedores()
        {
            lnBazarHub = new LNBazarHub();
        }
        public void InsertarProveedor(EProveedores proveedor)
        {
            lnBazarHub.InsertarProveedor(proveedor);
        }

        public void ActualizarProveedor(EProveedores proveedor)
        {
            lnBazarHub.ActualizarProveedor(proveedor);
        }

        public void ActualizarEstadoProveedor(int proveedorID, string estado)
        {
            lnBazarHub.ActualizarProveedorEstado(proveedorID, estado);
        }

        public void ActualizarFechaEdicionProveedor(int proveedorID, DateTime fechaEdicion)
        {
            lnBazarHub.ActualizarProveedorFechaEdicion(proveedorID, fechaEdicion);
        }

        public List<EProveedores> ObtenerTodosProveedores()
        {
            return lnBazarHub.ObtenerTodosProveedores();
        }
    }
}