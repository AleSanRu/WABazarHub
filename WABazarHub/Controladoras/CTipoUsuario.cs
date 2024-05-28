using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WABazarHub.Comunicacion;
using WABazarHub.ServiceReference1;

namespace WABazarHub.Controladoras
{
    public class CTipoUsuario
    {
        private LNBazarHub lnBazarHub;
        public CTipoUsuario()
        {
            lnBazarHub = new LNBazarHub();
        }
        public void InsertarTipoUsuario(ETipoUsuario tipoUsuario)
        {
            lnBazarHub.InsertarTipoUsuario(tipoUsuario);
        }

        public void ActualizarTipoUsuario(ETipoUsuario tipoUsuario)
        {
            lnBazarHub.ActualizarTipoUsuario(tipoUsuario);
        }

        public void ActualizarEstadoTipoUsuario(int tipoUsuarioID, string estado)
        {
            lnBazarHub.ActualizarTipoUsuarioEstado(tipoUsuarioID, estado);
        }

        public void ActualizarFechaEdicionTipoUsuario(int tipoUsuarioID, DateTime fechaEdicion)
        {
            lnBazarHub.ActualizarTipoUsuarioFechaEdicion(tipoUsuarioID, fechaEdicion);
        }

        public List<ETipoUsuario> ObtenerTodosTiposUsuario()
        {
            return lnBazarHub.ObtenerTodosTiposUsuario();
        }
    }
}