<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="WABazarHub.FormulariosWeb.RegistroUsuario" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
    <link href="../Estilos/EstilosInicioSesion.css" rel="stylesheet" />
    <style>
        body {
            background: linear-gradient(135deg, #6E8EFB, #88D3CE);
            color: #333;
            font-family: 'Segoe UI', sans-serif;
            overflow-x: hidden;
        }

        .registro-usuario-container {
            max-width: 500px;
            margin: 2em auto;
            padding: 2em;
            background-color: #ffffffee; /* Sutil transparencia */
            border-radius: 15px;
            box-shadow: 0 10px 25px rgba(0,0,0,0.1);
            border: 1px solid rgba(255,255,255,0.3);
            backdrop-filter: blur(10px);
        }

        .registro-usuario-container h2 {
            color: #0056b3;
            margin-bottom: 1em;
            text-transform: uppercase;
            text-align: center;
            letter-spacing: 1px;
        }

        .form-group label {
            color: #0056b3;
            font-weight: bold;
            letter-spacing: 0.5px;
        }

        .form-control {
            border-radius: 5px;
            border: 1px solid #ced4da;
            padding: 0.75em;
            margin-bottom: 1.5em;
            transition: all 0.3s ease-in-out;
        }

        .form-control:focus {
            box-shadow: 0 0 0 0.2rem rgba(108, 92, 231, 0.25);
            border-color: #6c5ce7;
            background-color: #f8f9fa;
            transform: translateY(-3px);
        }

        .btn-primary {
            width: auto;
            padding: 10px 30px;
            background-color: #007bff;
            border: none;
            border-radius: 5px;
            transition: background-color 0.3s ease;
            cursor: pointer;
            display: block;
            margin: 0 auto;
            font-weight: bold;
        }

        .btn-primary:hover {
            background-color: #0056b3;
            transform: scale(1.05);
            box-shadow: 0 5px 15px rgba(0,0,0,0.2);
        }

        /* Efecto hover para los inputs */
        .form-control:hover {
            background-color: #e9ecef;
        }
    </style>
</head  >
<body>
    <div class="registro-usuario-container">
        <form class="needs-validation" novalidate>
            <h2 class="mb-3">Registro de Usuario</h2>
            <div class="form-group">
                <label for="username">Nombre de Usuario</label>
                <input type="text" class="form-control" id="username" placeholder="Nombre de Usuario" required>
                <div class="invalid-feedback">Por favor, introduce tu nombre de usuario.</div>
            </div>
            <div class="form-group">
                <label for="email">Correo Electrónico</label>
                <input type="email" class="form-control" id="email" placeholder="Correo Electrónico" required>
                <div class="invalid-feedback">Por favor, introduce una dirección de correo válida.</div>
            </div>
            <div class="form-group">
                <label for="password">Contraseña</label>
                <input type="password" class="form-control" id="password" placeholder="Contraseña" required>
                <div class="invalid-feedback">Por favor, introduce una contraseña.</div>
            </div>
            <button type="submit" class="btn btn-primary">Registrarse</button>
        </form>
    </div>
</body>
</html>
