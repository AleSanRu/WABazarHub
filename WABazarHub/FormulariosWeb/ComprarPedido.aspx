<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestraInicio.Master" AutoEventWireup="true" CodeBehind="ComprarPedido.aspx.cs" Inherits="WABazarHub.FormulariosWeb.ComprarPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td style="width: 250px; height: 250px;">
                
                <asp:Image ID="imgQR" runat="server" Width="250px" Height="250px" />
            </td>
            <td>
                <h2>Productos comprados</h2>
                <asp:Literal ID="litProductos" runat="server"></asp:Literal>
            </td>
        </tr>
    </table>
</asp:Content>
