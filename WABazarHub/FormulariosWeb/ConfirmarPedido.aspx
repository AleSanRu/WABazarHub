<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestraInicio.Master" AutoEventWireup="true" CodeBehind="ConfirmarPedido.aspx.cs" Inherits="WABazarHub.FormulariosWeb.ConfirmarPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Productos Seleccionados:</h2>
    <div class="container">
        <div class="row">
            <div class="col">
                <asp:Repeater ID="rptProductosSeleccionados" runat="server">
                    <ItemTemplate>
                        <div class="row mb-2">
                            <div class="col">
                                <div><strong>Nombre:</strong> <%# Eval("Nombre") %></div>
                                <div><strong>Precio:</strong> <%# Eval("Precio", "{0:C}") %></div>
                                <!-- Agrega el botón de eliminación -->
                                <asp:Button ID="btnEliminar" runat="server" CommandName="Eliminar" CommandArgument='<%# Eval("CategoriaID") %>' Text="Eliminar" CssClass="btn btn-danger" OnCommand="btnEliminar_Command" />
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <!-- Botón de confirmación -->
                <asp:Button ID="btnConfirmarPedido" runat="server" Text="Confirmar Pedido" CssClass="btn btn-primary" OnClick="btnConfirmarPedido_Click" OnClientClick="return confirm('¿Está seguro de confirmar el pedido?');" />
            </div>
        </div>
    </div>
</asp:Content>
