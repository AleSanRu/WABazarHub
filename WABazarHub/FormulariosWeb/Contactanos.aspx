<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestraInicio.Master" AutoEventWireup="true" CodeBehind="Contactanos.aspx.cs" Inherits="WABazarHub.FormulariosWeb.Contactanos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .contact-form {
            max-width: 600px;
            margin: 0 auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 10px;
            background-color: #f9f9f9;
        }
        .contact-form label {
            display: block;
            margin-bottom: 10px;
            font-weight: bold;
        }
        .contact-form input, .contact-form textarea {
            width: 100%;
            padding: 10px;
            margin-bottom: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
        .contact-form button {
            padding: 10px 20px;
            background-color: #5cb85c;
            color: #fff;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
        .contact-form button:hover {
            background-color: #4cae4c;
        }
        .error-message {
            color: red;
            margin-bottom: 20px;
        }
        .success-message {
            color: green;
            margin-bottom: 20px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contact-form">
        <h2>Enviar Recomendaciones</h2>
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" placeholder="Tu nombre"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" placeholder="Tu correo electrónico"></asp:TextBox>
        <asp:TextBox ID="txtAsunto" runat="server" placeholder="Asunto"></asp:TextBox>
        <asp:TextBox ID="txtMensaje" runat="server" TextMode="MultiLine" Rows="6" placeholder="Tu recomendación"></asp:TextBox>
        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
    </div>
</asp:Content>
