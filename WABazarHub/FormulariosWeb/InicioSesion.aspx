<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="WABazarHub.FormulariosWeb.InicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
    <link href="../Estilos/EstilosInicioSesion.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="containerP">
            <div class="row">
                <div class="col">
                    <h1 class="">Bazar una tienda online a otro estilo</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-4 align-self-center order-last">
                    <asp:Panel ID="loginPanel" runat="server" CssClass="card fadeIn">
                        <div class="card-header">Iniciar Sesión</div>
                        <div class="card-body">
                            <asp:Label ID="lblUsuario" runat="server" Text="Usuario:" AssociatedControlID="txtUsuario"></asp:Label>
                            <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:Label ID="lblPassword" runat="server" Text="Contraseña:" AssociatedControlID="txtPassword" CssClass="mt-3"></asp:Label>
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                            <asp:Label ID="lblCaptcha" runat="server" CssClass="mt-3"></asp:Label>
                            <asp:TextBox ID="txtCaptcha" runat="server" CssClass="form-control mt-3"></asp:TextBox>
                            <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" CssClass="btn btn-primary mt-3" OnClick="btnLogin_Click" />
                            <asp:Label ID="lblMensaje" runat="server" CssClass="mt-3"></asp:Label>
                            <asp:LinkButton ID="lnkRegistro" runat="server" CssClass="btn btn-link mt-3" OnClick="lnkRegistro_Click">Registrarse</asp:LinkButton>
                        </div>
                    </asp:Panel>

                    <asp:Panel ID="authPanel" runat="server" CssClass="card" Visible="false">
                        <div class="card-header">Autenticación de Dos Pasos</div>
                        <div class="card-body slideRight">
                            <asp:Label ID="lblAuthCode" runat="server" Text="Código de Autenticación:" CssClass="mt-3"></asp:Label>
                            <asp:TextBox ID="txtAuthCode" runat="server" CssClass="form-control mt-3"></asp:TextBox>
                            <asp:Button ID="btnAuth" runat="server" Text="Verificar Código" CssClass="btn btn-primary mt-3" OnClick="btnAuth_Click" />
                            <asp:Label ID="Label1" runat="server" CssClass="mt-3"></asp:Label>
                        </div>
                    </asp:Panel>
                </div>
                <div class="col-4 align-self-center order-1">
                </div>
            </div>
            <div class="row">
                <div class="col mt-5">
                    <p class="mb-0 text-muted"><% Response.Write(DateTime.Now.ToString("dddd, dd MMMM yyyy")); %></p>
                    <p class="mb-0 text-muted"><% Response.Write(DateTime.Now.ToString("HH:mm:ss")); %></p>
                </div>
            </div>
            <asp:Panel ID="captchaPanel" runat="server" CssClass="card" Visible="false">
                <div class="card-body slideRight">
                </div>
            </asp:Panel>
        </div>
        <asp:Panel ID="alertPanel" runat="server" CssClass="alert alert-dismissible fade show" Visible="false">
            <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                <span aria-hidden="true">&times;</span>
            </button>
            <asp:Label ID="alertMessage" runat="server"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
