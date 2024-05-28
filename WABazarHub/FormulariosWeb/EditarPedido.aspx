<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestraInicio.Master" AutoEventWireup="true" CodeBehind="EditarPedido.aspx.cs" Inherits="WABazarHub.FormulariosWeb.EditarPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Editar Pedido</h2>
    <asp:DetailsView ID="dvPedido" runat="server" Height="50px" Width="100%" AutoGenerateRows="False" DataKeyNames="PedidoID" DefaultMode="Edit" OnItemUpdating="dvPedido_ItemUpdating">
        <Fields>
            <asp:BoundField DataField="PedidoID" HeaderText="Pedido ID" ReadOnly="True" />
            <asp:BoundField DataField="UsuarioID" HeaderText="Usuario ID" ReadOnly="True" />
            <asp:TemplateField HeaderText="Fecha del Pedido">
                <EditItemTemplate>
                    <asp:TextBox ID="txtFechaPedido" runat="server" Text='<%# Bind("FechaPedido", "{0:yyyy-MM-dd}") %>' TextMode="Date"></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="DireccionEnvio" HeaderText="Dirección de Envío" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" />
            <asp:CommandField ShowEditButton="True" EditText="Guardar Cambios" />
        </Fields>
    </asp:DetailsView>
</asp:Content>
<a href="../MasterPage/PaginaMaestraInicio.Master.cs">../MasterPage/PaginaMaestraInicio.Master.cs</a>