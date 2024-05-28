<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestraInicio.Master" AutoEventWireup="true" CodeBehind="PaginaInicio.aspx.cs" Inherits="WABazarHub.FormulariosWeb.PaginaInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .bienvenida {
            padding: 20px;
            background-color: #f0f9ff;
            border-radius: 10px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
            margin-top: 20px;
        }

        .bienvenida h2 {
            color: #0056b3;
        }

        .bienvenida p {
            color: #333;
        }

        .accion {
            text-align: center;
            margin-top: 30px;
        }

        .carousel-inner img {
            width: 100%;
            height: auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
            <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img class="d-block w-100" src="../Imagenes/IMGBazar.jpg" alt="Primera imagen">
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" src="../Imagenes/IMGBazar.jpg" alt="Segunda imagen">
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" src="../Imagenes/IMGBazar.jpg" alt="Tercera imagen">
            </div>
        </div>
        <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Anterior</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Siguiente</span>
        </a>
    </div>

    <div class="bienvenida">
        <h2>Bienvenido a Bazar Hub Online</h2>
        <p>¡Estamos emocionados de tenerte con nosotros! Explora nuestra amplia gama de productos y encuentra exactamente lo que necesitas. Desde gadgets hasta ropa y más, todo a tu alcance.</p>
        <p>Si tienes alguna pregunta o necesitas asistencia, no dudes en contactarnos. Estamos aquí para ayudar.</p>
        <div class="accion">
            <asp:Button ID="btnExplorar" runat="server" Text="Explorar Ahora" CssClass="btn btn-primary" PostBackUrl="~/CatalogoProductos.aspx" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <div class="card">
                <img class="card-img-top" src="../Imagenes/IMGBazar.jpg" alt="Imagen 1">
                <div class="card-body">
                    <h5 class="card-title">Título Tarjeta 1</h5>
                    <p class="card-text">Descripción breve de lo que la tarjeta está destacando.</p>
                    <a href="#" class="btn btn-primary">Más Información</a>
                </div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="card">
                <img class="card-img-top" src="../Imagenes/IMGBazar.jpg" alt="Imagen 2">
                <div class="card-body">
                    <h5 class="card-title">Título Tarjeta 2</h5>
                    <p class="card-text">Una descripción breve para proporcionar más contexto sobre la tarjeta.</p>
                    <a href="#" class="btn btn-primary">Más Información</a>
                </div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="card">
                <img class="card-img-top" src="../Imagenes/IMGBazar.jpg" alt="Imagen 3">
                <div class="card-body">
                    <h5 class="card-title">Título Tarjeta 3</h5>
                    <p class="card-text">Breve descripción sobre el contenido o la oferta de la tarjeta.</p>
                    <a href="#" class="btn btn-primary">Más Información</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>