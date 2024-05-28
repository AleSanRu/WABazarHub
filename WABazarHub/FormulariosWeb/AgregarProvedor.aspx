<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestraInicio.Master" AutoEventWireup="true" CodeBehind="AgregarProvedor.aspx.cs" Inherits="WABazarHub.FormulariosWeb.AgregarProvedor" %>
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
        <h2>Insertar Nuevo Proveedor</h2>
        <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
        
        <label for="txtNombreEmpresa">Nombre de la Empresa:</label>
        <asp:TextBox ID="txtNombreEmpresa" runat="server" required="true" placeholder="Ingrese el nombre de la empresa"></asp:TextBox>

        <label for="txtContacto">Contacto:</label>
        <asp:TextBox ID="txtContacto" runat="server" required="true" placeholder="Ingrese el contacto"></asp:TextBox>

        <label for="txtEmail">Email:</label>
        <asp:TextBox ID="txtEmail" runat="server" required="true" placeholder="Ingrese el email"></asp:TextBox>

        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    </div>
</asp:Content>