<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestraInicio.Master" AutoEventWireup="true" CodeBehind="AgregarPedido.aspx.cs" Inherits="WABazarHub.FormulariosWeb.AgregarPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .form-style {
            margin: 20px;
        }
        .form-style label {
            display: block;
            margin-top: 10px;
        }
        .form-style input, .form-style select {
            width: 100%;
            padding: 8px;
            margin-top: 5px;
        }
        .form-style input[type="submit"] {
            margin-top: 20px;
            width: auto;
            padding: 10px 20px;
            background-color: #007bff;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
        .form-style input[type="submit"]:hover {
            background-color: #0056b3;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-style">
        <h2>Agregar Nuevo Pedido</h2>
        <label for="ddlUsuario">Usuario:</label>
        <asp:DropDownList ID="ddlUsuario" runat="server"></asp:DropDownList>
        
        <label for="txtFechaPedido">Fecha del Pedido:</label>
        <asp:Calendar ID="calFechaPedido" runat="server" SelectionMode="Day"></asp:Calendar>
        
        <label for="txtDireccionEnvio">Dirección de Envío:</label>
        <asp:TextBox ID="txtDireccionEnvio" runat="server"  Rows="3"></asp:TextBox>
        <br />
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    </div>
</asp:Content>