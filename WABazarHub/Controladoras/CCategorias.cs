using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WABazarHub.Comunicacion;
using WABazarHub.ServiceReference1;

namespace WABazarHub.Controladoras
{
    public class CCategorias
    {
        private LNBazarHub lnBazarHub;
        public CCategorias()
        {
            lnBazarHub = new LNBazarHub();
        }
        public void InsertarCategoria(ECategorias categoria)
        {
            lnBazarHub.InsertarCategoria(categoria);
        }

        public void ActualizarCategoria(ECategorias categoria)
        {
            lnBazarHub.ActualizarCategoria(categoria);
        }

        public void ActualizarEstadoCategoria(int categoriaID, string estado)
        {
            lnBazarHub.ActualizarCategoriaEstado(categoriaID, estado);
        }

        public void ActualizarFechaEdicionCategoria(int categoriaID, DateTime fechaEdicion)
        {
            lnBazarHub.ActualizarCategoriaFechaEdicion(categoriaID, fechaEdicion);
        }

        public List<ECategorias> ObtenerTodasCategorias()
        {
            return lnBazarHub.ObtenerTodasCategorias();
        }
    }
}