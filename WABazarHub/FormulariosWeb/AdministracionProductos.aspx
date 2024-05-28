<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestraInicio.Master" AutoEventWireup="true" CodeBehind="AdministracionProductos.aspx.cs" Inherits="WABazarHub.FormulariosWeb.AdministracionProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Administración de Productos</h2>
    <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="False" 
        OnRowCommand="gvProductos_RowCommand" DataKeyNames="ProductoID" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripción" SortExpression="Descripcion" />
            <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
            <asp:BoundField DataField="Stock" HeaderText="Stock" SortExpression="Stock" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("ProductoID") %>' Text="Editar" />
                    <asp:Button ID="BtnCancelar" runat="server" CommandName="Cancelar" 
                            CommandArgument='<%# Eval("ProductoID") %>'
                            Text="Eliminar" CssClass="btn btn-cancelar" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="btnAgregarProducto" runat="server" Text="Agregar Nuevo Producto" OnClick="btnAgregarProducto_Click" />
</asp:Content>