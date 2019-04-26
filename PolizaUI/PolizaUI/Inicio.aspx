<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="PolizaUI.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  
    <meta http-equiv="X-UA-Compatible" content="IE=Edge"/>
	<meta name="viewport" content="width=device-width, initial-scale=1"/>
	<meta name="keywords" content=""/>
	<meta name="description" content=""/>
   
    <link rel="stylesheet" href="css/bootstrap.min.css"/>
	<link rel="stylesheet" href="css/font-awesome.min.css"/>
	<link rel="stylesheet" href="css/nivo-lightbox.css"/>
	<link rel="stylesheet" href="css/nivo_themes/default/default.css"/>
	<link rel="stylesheet" href="css/style.css"/>

	<!-- google web font css -->
	<link href='http://fonts.googleapis.com/css?family=Raleway:400,300,600,700' rel='stylesheet' type='text/css'/>
    
<%--TITULO PAGINA--%>

    <title>Seguros Americanos</title>


</head>

<%--CUERPO--%>

<body>

    <form id="form1" runat="server">
        <div>
            <div class="navbar navbar-default navbar-fixed-top" role="navigation">
	    <div class="container">

<%--TITULO DE BARRA--%>
		<div class="navbar-header">
			<button class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
				<span class="icon icon-bar"></span>
				<span class="icon icon-bar"></span>
				<span class="icon icon-bar"></span>
			</button>
			<a href=""Inicio.aspx"" class="navbar-brand smoothScroll">Seguros Americanos</a>
		</div>

<%--BARRA DE OPCIONES--%>
		<div class="collapse navbar-collapse">
			<ul class="nav navbar-nav navbar-right">			
				<li><a href="Paginas/Cliente/Poliza.aspx" class="smoothScroll">Servicio</a></li>
                <li><a href="Paginas/Administrativo/Acercade.aspx" class="smoothScroll">Acerca de nosotros</a></li>
				<li><a href="Paginas/Administrativo/Contactenos.aspx" class="smoothScroll">Contáctenos</a></li>
<%--MENU DESPLEGABLE--%>
                       <li><a class="dropdown-toggle" data-toggle="dropdown" href="# ">Administrativo<span class="caret"></span></a>
                            <ul class="dropdown-menu">
                                <li><a href="Paginas/Administrativo/Persona.aspx">Personas</a></li>
                                <li><a href="Paginas/Administrativo/Identificacion.aspx">Identificacion</a></li>
                                <li><a href="Paginas/Administrativo/Beneficiario.aspx">Beneficiario</a></li>
                                <li><a href="Paginas/Cliente/Poliza.aspx">Poliza</a></li>
                                <li><a href="Paginas/Cliente/Venta.aspx">Venta</a></li>
                                <li><a href="Paginas/Administrativo/MetodoPago.aspx">MetodoPago</a></li>
                                <li><a href="Paginas/Administrativo/TarjetaCreditoDeb.aspx">Tarjeta_Cred_Deb</a></li>
                                <li><a href="Paginas/Administrativo/Planes.aspx">Planes</a></li>
                                <li><a href="Paginas/Administrativo/Cobertura.aspx">Cobertura</a></li>
                                <li><a href="Paginas/Administrativo/Provincia.aspx">Provincia</a></li>
                                <li><a href="Paginas/Administrativo/Canton.aspx">Canton</a></li>
                                <li><a href="Paginas/Administrativo/Distrito.aspx">Distrito</a></li>
                            </ul>
                        </li>
                            <ul class="nav navbar-nav navbar-right">
                                <li id="admin"><a href="Paginas/Administrativo/Login.aspx">Login</a></li>
                                <li><label id="Usuario" runat="server"></label></li>

                            </ul>            
			</ul>
		</div>

	</div>
</div>		

<div id="home">
	<div class="container">
		<div class="row">
			<div class="col-md-offset-6 col-md-6 col-sm-offset-6 col-sm-6">
				<h2>Bienvenido a</h2>
                <h1> <strong>Seguros Americanos</strong></h1>
                <a href="Paginas/Administrativo/Login.aspx" class="btn btn-default smoothScroll">Iniciar sesión</a>	
            </div>
		</div>
	</div>
</div>

<%--PARTE INFORMATIVA--%>

<div id="service">
	<div class="container">
		
        <div class="row">
			<div class="col-md-12 col-sm-12">
				<h2>Como adquirir nuestros seguros.</h2>
			</div>
			
            <div class="col-md-4 col-sm-4">
				<i class="fa fa-cubes"></i>
				<h3>Registrarse</h3>
                <p>Como primer paso, deberá registrarse en nuestra pagina.<a href="Registrarse.aspx" target="registro">dar click aquí</a></p>
			</div>
			<div class="col-md-4 col-sm-4">
				<i class="fa fa-cogs"></i>
				<h3>Selección de el seguro</h3>
				<p>Seleccionar el seguro que más se ajuste a sus necesidades.</p>
			</div>
			<div class="col-md-4 col-sm-4">
				<i class="fa fa-group"></i>
				<h3>Ingresar metodo de pago</h3>
				<p>Sirvase ingresar su tarjeta de crédito o debito para realizar el pago.</p>
			</div>
		</div>
	</div>
</div>

<!-- divider section -->
<div class="container">
	<div class="row">
		<div class="col-md-1 col-sm-1"></div>
		<div class="col-md-10 col-sm-10">
			<hr>
		</div>
		<div class="col-md-1 col-sm-1"></div>
	</div>
</div>

<!-- about section -->
<div id="about">
	<div class="container">
		<div class="row">
			<div class="col-md-12 col-sm-12">
				<h2>Nuestra historia</h2>
			</div>
			<div class="col-md-6 col-sm-6">                
				<img src="IMG/89cad-9-curiosidades-historicas-sobre-el-origen-de-los-seguros-min.jpg" alt="about img"/>
			</div>
			<div class="col-md-6 col-sm-6">
				
                       <p>Desde diciembre del 2010, Seguros Americanos fue autorizada por Çla 
                        Superintendencia General de Seguros (SUGESE), cumpliendo con todos 
                        los requisitos legales y financieros de la Ley Reguladora del Mercado
                        de Seguros para operar en Costa Rica, desde ese momento ha mantenido una 
                        posición de liderazgo en el mercado de seguros de personas.</p>

                    <p>Seguros Americanos continua con bases sólidas, su calificación de riesgo medida 
                        por la  Calificadora Fitch Rating es de AA-, destacando en su informe oficial factores
                        claves como: perfil financiero intrínseco, el cual ha mostrado una evolución favorable registrando
                        mejoras de manera sostenida en todas sus métricas durante los últimos 3 años, incremento en el capital, 
                        altos índices de desempeño y rentabilidad, niveles de siniestralidad sostenidamente bajos, eficiencia operativa,
                        amplio conocimiento del negocio en Costa Rica y un programa de reaseguro sólido.La compañía se encuentra fortalecida por 
                        la  unión de dos importantes grupos con amplia experiencia y reconocimiento en el mercado nacional e internacional. Nuestros 
                        socios son: Compañía Internacional de Seguros (IS) y Cooperativa Nacional de Educadores (COOPENAE)”</p>
			</div>
		</div>
	</div>
</div>


<!-- divider section -->
<div class="container">
	<div class="row">
		<div class="col-md-1 col-sm-1"></div>
		<div class="col-md-10 col-sm-10">
			<hr>
		</div>
		<div class="col-md-1 col-sm-1"></div>
	</div>
</div>

<!-- footer section -->
<footer>
	<div class="container">
		<div class="row">
			<div class="col-md-6 col-sm-6">
				 <h2>Dirección</h2>
                    <p>Plaza Roosevelt, 150 oeste, San Pedro, San José</p>
                    <p>Email:info@segurosamericanos.com</p>
                    <p>Tel:2256-9078</p>
			</div>
	
		</div>
	</div>
</footer>

<!-- divider section -->
<div class="container">
	<div class="row">
		<div class="col-md-1 col-sm-1"></div>
		<div class="col-md-10 col-sm-10">
			<hr>
		</div>
		<div class="col-md-1 col-sm-1"></div>
	</div>
</div>

<!-- copyright section -->
<div class="copyright">
	<div class="container">
		<div class="row">
			<div class="col-md-12 col-sm-12">
				<p>Copyright &copy; 2019 Rosa Álvarez design 
                
               <%-- - Design: <a rel="nofollow" href="http://www.tooplate.com" target="_parent">Tooplate</a></p>--%>
			</div>
		</div>
	</div>
</div>

<!-- scrolltop section -->
<a href="#top" class="go-top"><i class="fa fa-angle-up"></i></a>


<!-- javascript js -->	
<script src="js/jquery.js"></script>
<script src="js/bootstrap.min.js"></script>	
<script src="js/nivo-lightbox.min.js"></script>
<script src="js/smoothscroll.js"></script>
<script src="js/jquery.nav.js"></script>
<script src="js/isotope.js"></script>
<script src="js/imagesloaded.min.js"></script>
<script src="js/custom.js"></script>

         </div>
    </form>
</body>
</html>
