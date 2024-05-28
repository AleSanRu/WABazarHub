using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WABazarHub.Comunicacion;
using WABazarHub.ServiceReference1;

namespace WABazarHub.Controladoras
{
    public class CDireccionEnvio
    {
        private LNBazarHub lnBazarHub;
        public CDireccionEnvio()
        {
            lnBazarHub = new LNBazarHub();
        }
        public void InsertarDireccionEnvio(EDireccionesEnvio direccionEnvio)
        {
            lnBazarHub.InsertarDireccionEnvio(direccionEnvio);
        }

        public void ActualizarDireccionEnvio(EDireccionesEnvio direccionEnvio)
        {
            lnBazarHub.ActualizarDireccionEnvio(direccionEnvio);
        }

        public void ActualizarEstadoDireccionEnvio(int direccionID, string estado)
        {
            lnBazarHub.ActualizarDireccionEnvioEstado(direccionID, estado);
        }

        public void ActualizarFechaEdicionDireccionEnvio(int direccionID, DateTime fechaEdicion)
        {
            lnBazarHub.ActualizarDireccionEnvioFechaEdicion(direccionID, fechaEdicion);
        }

        public List<EDireccionesEnvio> ObtenerTodasDireccionesEnvio()
        {
            return lnBazarHub.ObtenerTodasDireccionesEnvio();
        }
    }
}