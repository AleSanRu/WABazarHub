<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestraInicio.Master" AutoEventWireup="true" CodeBehind="AdministracionProveedores.aspx.cs" Inherits="WABazarHub.FormulariosWeb.AdministracionProveedores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Administración de Proveedores</h2>
    <asp:GridView ID="gvProveedores" runat="server" AutoGenerateColumns="False"
        OnRowCommand="gvProveedores_RowCommand" DataKeyNames="ProveedorID" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="NombreEmpresa" HeaderText="Nombre" SortExpression="NombreEmpresa" />
            <asp:BoundField DataField="Contacto" HeaderText="Contacto" SortExpression="Contacto" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
            <asp:BoundField DataField="FechaDeEdicion" HeaderText="Fecha de Edición" SortExpression="FechaDeEdicion" DataFormatString="{0:dd/MM/yyyy}" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnEditarProveedor" runat="server" CommandName="Edit" CommandArgument='<%# Eval("ProveedorID") %>' Text="Editar" />
                    <asp:Button ID="btnEliminarProveedor" runat="server" CommandName="Eliminar"
                        CommandArgument='<%# Eval("ProveedorID") %>'
                        Text="Eliminar" CssClass="btn btn-eliminar" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="btnAgregarProveedor" runat="server" Text="Agregar Nuevo Proveedor" OnClick="btnAgregarProveedor_Click" />
</asp:Content>