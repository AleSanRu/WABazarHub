using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using WABazarHub.ServiceReference1;

namespace WABazarHub.Comunicacion
{
    public class LNBazarHub
    {
        #region Variables
        private IService1 _lnServiciosBazar;
        #endregion
        #region Constructor
        public LNBazarHub()
        {
            _lnServiciosBazar = new Service1Client();
        }
        #endregion
        #region Usuarios
        public void InsertarUsuario(EUsuario usuario)
        {
            _lnServiciosBazar.InsertarUsuario(usuario);
        }

        public void ActualizarUsuario(EUsuario usuario)
        {
            _lnServiciosBazar.ActualizarUsuario(usuario);
        }

        public void ActualizarUsuarioEstado(int usuarioID, string estado)
        {
            _lnServiciosBazar.ActualizarUsuarioEstado(usuarioID, estado);
        }

        public void ActualizarUsuarioFechaEdicion(int usuarioID, DateTime fechaEdicion)
        {
            _lnServiciosBazar.ActualizarUsuarioFechaEdicion(usuarioID, fechaEdicion);
        }

        public List<EUsuario> ObtenerTodosUsuarios()
        {
            return _lnServiciosBazar.ObtenerTodosUsuarios().ToList();
        }
        #endregion
        #region TipoUsuario
        public void InsertarTipoUsuario(ETipoUsuario tipoUsuario)
        {
            _lnServiciosBazar.InsertarTipoUsuario(tipoUsuario);
        }

        public void ActualizarTipoUsuario(ETipoUsuario tipoUsuario)
        {
            _lnServiciosBazar.ActualizarTipoUsuario(tipoUsuario);
        }

        public void ActualizarTipoUsuarioEstado(int tipoUsuarioID, string estado)
        {
            _lnServiciosBazar.ActualizarTipoUsuarioEstado(tipoUsuarioID, estado);
        }

        public void ActualizarTipoUsuarioFechaEdicion(int tipoUsuarioID, DateTime fechaEdicion)
        {
            _lnServiciosBazar.ActualizarTipoUsuarioFechaEdicion(tipoUsuarioID, fechaEdicion);
        }

        public List<ETipoUsuario> ObtenerTodosTiposUsuario()
        {
            return _lnServiciosBazar.ObtenerTodosTiposUsuario().ToList();
        }
        #endregion
        #region Productos
        public void InsertarProducto(EProductos producto)
        {
            _lnServiciosBazar.InsertarProducto(producto);
        }

        public void ActualizarProducto(EProductos producto)
        {
            _lnServiciosBazar.ActualizarProducto(producto);
        }

        public void ActualizarProductoEstado(int productoID, string estado)
        {
            _lnServiciosBazar.ActualizarProductoEstado(productoID, estado);
        }

        public void ActualizarProductoFechaEdicion(int productoID, DateTime fechaEdicion)
        {
            _lnServiciosBazar.ActualizarProductoFechaEdicion(productoID, fechaEdicion);
        }

        public List<EProductos> ObtenerTodosProductos()
        {
            return _lnServiciosBazar.ObtenerTodosProductos().ToList();
        }
        #endregion
        #region Pedidos
        public void InsertarPedido(EPedidos pedido)
        {
            _lnServiciosBazar.InsertarPedido(pedido);
        }

        public void ActualizarPedido(EPedidos pedido)
        {
            _lnServiciosBazar.ActualizarPedido(pedido);
        }

        public void ActualizarPedidoEstado(int pedidoID, string estado)
        {
            _lnServiciosBazar.ActualizarPedidoEstado(pedidoID, estado);
        }

        public void ActualizarPedidoFechaEdicion(int pedidoID, DateTime fechaEdicion)
        {
            _lnServiciosBazar.ActualizarPedidoFechaEdicion(pedidoID, fechaEdicion);
        }

        public List<EPedidos> ObtenerTodosPedidos()
        {
            return _lnServiciosBazar.ObtenerTodosPedidos().ToList();
        }
        #endregion
        #region DetallesPedido
        public void InsertarDetallePedido(EDetallesPedido detallePedido)
        {
            _lnServiciosBazar.InsertarDetallePedido(detallePedido);
        }

        public void ActualizarDetallePedido(EDetallesPedido detallePedido)
        {
            _lnServiciosBazar.ActualizarDetallePedido(detallePedido);
        }

        public void ActualizarDetallePedidoEstado(int detalleID, string estado)
        {
            _lnServiciosBazar.ActualizarDetallePedidoEstado(detalleID, estado);
        }

        public void ActualizarDetallePedidoFechaEdicion(int detalleID, DateTime fechaEdicion)
        {
            _lnServiciosBazar.ActualizarDetallePedidoFechaEdicion(detalleID, fechaEdicion);
        }

        public List<EDetallesPedido> ObtenerTodosDetallesPedidos()
        {
            return _lnServiciosBazar.ObtenerTodosDetallesPedidos().ToList();
        }
        #endregion
        #region DireccionesEnvio
        public void InsertarDireccionEnvio(EDireccionesEnvio direccionEnvio)
        {
            _lnServiciosBazar.InsertarDireccionEnvio(direccionEnvio);
        }

        public void ActualizarDireccionEnvio(EDireccionesEnvio direccionEnvio)
        {
            _lnServiciosBazar.ActualizarDireccionEnvio(direccionEnvio);
        }

        public void ActualizarDireccionEnvioEstado(int direccionID, string estado)
        {
            _lnServiciosBazar.ActualizarDireccionEnvioEstado(direccionID, estado);
        }

        public void ActualizarDireccionEnvioFechaEdicion(int direccionID, DateTime fechaEdicion)
        {
            _lnServiciosBazar.ActualizarDireccionEnvioFechaEdicion(direccionID, fechaEdicion);
        }

        public List<EDireccionesEnvio> ObtenerTodasDireccionesEnvio()
        {
            return _lnServiciosBazar.ObtenerTodasDireccionesEnvio().ToList();
        }
        #endregion
        #region Proveedores
        public void InsertarProveedor(EProveedores proveedor)
        {
            _lnServiciosBazar.InsertarProveedor(proveedor);
        }

        public void ActualizarProveedor(EProveedores proveedor)
        {
            _lnServiciosBazar.ActualizarProveedor(proveedor);
        }

        public void ActualizarProveedorEstado(int proveedorID, string estado)
        {
            _lnServiciosBazar.ActualizarProveedorEstado(proveedorID, estado);
        }

        public void ActualizarProveedorFechaEdicion(int proveedorID, DateTime fechaEdicion)
        {
            _lnServiciosBazar.ActualizarProveedorFechaEdicion(proveedorID, fechaEdicion);
        }

        public List<EProveedores> ObtenerTodosProveedores()
        {
            return _lnServiciosBazar.ObtenerTodosProveedores().ToList();
        }
        #endregion
        #region Categorias
        public void InsertarCategoria(ECategorias categoria)
        {
            _lnServiciosBazar.InsertarCategoria(categoria);
        }

        public void ActualizarCategoria(ECategorias categoria)
        {
            _lnServiciosBazar.ActualizarCategoria(categoria);
        }

        public void ActualizarCategoriaEstado(int categoriaID, string estado)
        {
            _lnServiciosBazar.ActualizarCategoriaEstado(categoriaID, estado);
        }

        public void ActualizarCategoriaFechaEdicion(int categoriaID, DateTime fechaEdicion)
        {
            _lnServiciosBazar.ActualizarCategoriaFechaEdicion(categoriaID, fechaEdicion);
        }

        public List<ECategorias> ObtenerTodasCategorias()
        {
            return _lnServiciosBazar.ObtenerTodasCategorias().ToList();
        }
        #endregion
    }
}