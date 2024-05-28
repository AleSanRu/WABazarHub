<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestraInicio.Master" AutoEventWireup="true" CodeBehind="AdministracionPedidos.aspx.cs" Inherits="WABazarHub.FormulariosWeb.AdministracionPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .grid-view {
            width: 100%;
            margin-top: 20px;
        }
        .btn {
            padding: 5px 10px;
            color: #fff;
            background-color: #007BFF;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
        .btn:hover {
            background-color: #0056b3;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Administración de Pedidos</h2>
    <asp:GridView ID="gvPedidos" runat="server" AutoGenerateColumns="False" CssClass="grid-view"
        OnRowCommand="gvPedidos_RowCommand" DataKeyNames="PedidoID" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="PedidoID" HeaderText="Pedido ID" SortExpression="PedidoID" />
            <asp:BoundField DataField="UsuarioID" HeaderText="Usuario ID" SortExpression="UsuarioID" />
            <asp:BoundField DataField="FechaPedido" HeaderText="Fecha de Pedido" SortExpression="FechaPedido" DataFormatString="{0:dd/MM/yyyy}" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("PedidoID") %>' Text="Editar" CssClass="btn" />
                    <asp:Button ID="btnCancelar" runat="server" CommandName="Cancelar" CommandArgument='<%# Eval("PedidoID") %>' Text="Cancelar" CssClass="btn"  />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="btnAgregarPedido" runat="server" Text="Agregar Nuevo Pedido" OnClick="btnAgregarPedido_Click" CssClass="btn" />
</asp:Content>