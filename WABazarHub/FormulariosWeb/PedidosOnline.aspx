<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestraInicio.Master" AutoEventWireup="true" CodeBehind="PedidosOnline.aspx.cs" Inherits="WABazarHub.FormulariosWeb.PedidosOnline" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .pedidos-container {
            max-width: 600px;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 5px 15px rgba(0,0,0,0.1);
        }

        .pedidos-container h2 {
            text-align: center;
            margin-bottom: 20px;
        }

        .form-control, .btn-primary {
            margin-top: 10px;
        }

        .btn-primary {
            width: 100%;
            background-color: #007bff;
            border-color: #007bff;
        }

        .btn-primary:hover {
            background-color: #0056b3;
            border-color: #0056b3;
        }

        /* Estilos adicionales según necesites */
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pedidos-container">
        <h2>Realizar Pedido Online</h2>
        <form>
            <div class="form-group">
                <label for="productoSelect">Selecciona un Producto</label>
                <select class="form-control" id="productoSelect">
                    <option>Producto 1</option>
                    <option>Producto 2</option>
                </select>
            </div>
            
            <div class="form-group">
                <label for="cantidadProducto">Cantidad</label>
                <input type="number" class="form-control" id="cantidadProducto" min="1" value="1">
            </div>
            <div class="form-group">
                <label>Dirección de Envío</label>
                <input type="text" class="form-control" placeholder="Dirección completa">
            </div>
            <button type="submit" class="btn btn-primary">Enviar Pedido</button>
        </form>
    </div>
</asp:Content>