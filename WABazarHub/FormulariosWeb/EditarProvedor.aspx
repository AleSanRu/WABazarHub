<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestraInicio.Master" AutoEventWireup="true" CodeBehind="EditarProvedor.aspx.cs" Inherits="WABazarHub.FormulariosWeb.EditarProvedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Editar Proveedor</h2>
    <asp:DetailsView ID="dvProveedor" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" DataKeyNames="ProveedorID" DefaultMode="Edit" OnItemUpdating="dvProveedor_ItemUpdating">
        <Fields>
            <asp:BoundField DataField="ProveedorID" HeaderText="Proveedor ID" InsertVisible="False" ReadOnly="True" SortExpression="ProveedorID" />
            <asp:BoundField DataField="NombreEmpresa" HeaderText="Nombre de la Empresa" SortExpression="NombreEmpresa" />
            <asp:BoundField DataField="Contacto" HeaderText="Contacto" SortExpression="Contacto" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
            <asp:CommandField ShowEditButton="True" EditText="Guardar" />
        </Fields>
    </asp:DetailsView>
</asp:Content>