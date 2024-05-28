<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestraInicio.Master" AutoEventWireup="true" CodeBehind="InsertarProducto.aspx.cs" Inherits="WABazarHub.FormulariosWeb.InsertarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .form-style {
            margin: 20px;
        }
        .form-style label {
            display: block;
            margin: 10px 0px 5px;
        }
        .form-style input, .form-style textarea, .form-style select {
            width: 100%;
            padding: 8px;
        }
        .form-style input[type="submit"] {
            width: auto;
            padding: 8px 16px;
            background-color: #007BFF;
            color: white;
            border: none;
            cursor: pointer;
        }
        .form-style input[type="submit"]:hover {
            background-color: #0056b3;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-style">
        <h2>Insertar Nuevo Producto</h2>
        <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
        
        <label for="ddlCategoria">Categoría:</label>
        <asp:DropDownList ID="ddlCategoria" runat="server">
        </asp:DropDownList>

        <label for="ddlProveedor">Proveedor:</label>
        <asp:DropDownList ID="ddlProveedor" runat="server">
        </asp:DropDownList>

        <label for="txtNombre">Nombre:</label>
        <asp:TextBox ID="txtNombre" runat="server" required="true" placeholder="Ingrese el nombre del producto"></asp:TextBox>

        <label for="txtDescripcion">Descripción:</label>
        <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" Rows="4" required="true" placeholder="Ingrese una descripción"></asp:TextBox>

        <label for="txtPrecio">Precio:</label>
        <asp:TextBox ID="txtPrecio" runat="server" required="true" placeholder="0.00" TextMode="Number"></asp:TextBox>

        <label for="txtStock">Stock:</label>
        <asp:TextBox ID="txtStock" runat="server" required="true" placeholder="0" TextMode="Number"></asp:TextBox>

        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    </div>
</asp:Content>