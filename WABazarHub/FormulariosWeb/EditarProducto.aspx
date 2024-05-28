<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestraInicio.Master" AutoEventWireup="true" CodeBehind="EditarProducto.aspx.cs" Inherits="WABazarHub.FormulariosWeb.EditarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Editar Producto</h2>
    <asp:DetailsView ID="dvProducto" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" DataKeyNames="ProductoID" DefaultMode="Edit" OnItemUpdating="dvProducto_ItemUpdating">
        <Fields>
            <asp:BoundField DataField="ProductoID" HeaderText="Producto ID" InsertVisible="False" ReadOnly="True" SortExpression="ProductoID" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:TemplateField HeaderText="Descripción">
                <EditItemTemplate>
                    <asp:TextBox ID="txtDescripcion" runat="server" Text='<%# Bind("Descripcion") %>' TextMode="MultiLine" Rows="4"></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
            <asp:BoundField DataField="Stock" HeaderText="Stock" SortExpression="Stock" />
            <asp:CommandField ShowEditButton="True" EditText="Guardar" />
        </Fields>
    </asp:DetailsView>
</asp:Content>
