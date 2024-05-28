<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestraInicio.Master" AutoEventWireup="true" CodeBehind="Comentarios.aspx.cs" Inherits="WABazarHub.FormulariosWeb.Comentarios" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Administración de Productos</h2>
    
    <!-- Formulario para agregar comentarios -->
    <div>
        <h3>Agregar Comentario</h3>
        <asp:TextBox ID="txtComentario" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
        <asp:Button ID="btnAgregarComentario" runat="server" Text="Agregar Comentario" OnClick="btnAgregarComentario_Click" />
    </div>
    
    <!-- GridView para mostrar los productos -->
    <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="False" 
    OnRowCommand="gvProductos_RowCommand" DataKeyNames="ProductoID" AllowPaging="True">
    <%-- Columnas del GridView --%>
</asp:GridView>

    
    <br />
    
    <!-- GridView para mostrar los comentarios -->
    <h3>Comentarios Guardados</h3>
    <asp:GridView ID="gvComentarios" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ComentarioID" HeaderText="ID" />
            <asp:BoundField DataField="Comentario" HeaderText="Comentario" />
            <asp:BoundField DataField="UsuarioID" HeaderText="Usuario" />
            <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
        </Columns>
    </asp:GridView>
    
    <br />
    
    <!-- Botón para agregar nuevo producto -->
    <asp:Button ID="btnAgregarProducto" runat="server" Text="Agregar Nuevo Producto" OnClick="btnAgregarProducto_Click" />
</asp:Content>
