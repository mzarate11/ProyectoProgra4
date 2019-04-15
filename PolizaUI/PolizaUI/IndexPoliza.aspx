﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Poliza.Master" AutoEventWireup="true" CodeBehind="IndexPoliza.aspx.cs" Inherits="PolizaUI.IndexPoliza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <!-- primer div -->
    <div id="home">
        <div class="container">
            <div class="row">
                <div class="col-md-offset-6 col-md-6 col-sm-offset-6 col-sm-6">
                    <h2>Bienvenido a</h2>
                    <h1><strong>Seguros Americanos</strong></h1>

                    <!--Direcciona a registrarse-->
                    <a href="#service" class="btn btn-default smoothScroll">Registrarse</a>
                </div>
            </div>
        </div>
    </div>

    <!-- service section -->
    <div id="service">
        <div class="container">
            <div class="row">
                <div class="col-md-12 col-sm-12">
                    <h2>Como adquirir nuestros seguros</h2>
                </div>
                <div class="col-md-4 col-sm-4">
                    <i class="fa fa-group"></i>

                    <h3>Registrarse</h3>
                    <p>Como primer paso, deberá registrarse en nuestra pagina.<a href="index.html" target="registro">dar clic aquí</a></p>
                </div>
                <div class="col-md-4 col-sm-4">
                    <i class="fa fa-cogs"></i>
                    <h3>Selección de el seguro</h3>
                    <p>Seleccionar el seguro que más se ajuste a sus necesidades.</p>
                </div>
                <div class="col-md-4 col-sm-4">
                    <i class="fa fa-cubes"></i>
                    <h3>Ingresar metodo de pago</h3>
                    <p>Sirvase ingresar su tarjeta de crédito o debito para realizar el pago</p>
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
                    <img src="images/about-img.jpg" class="img-responsive" alt="about img">
                </div>
                <div class="col-md-6 col-sm-6">
                    <h3>Acerca de nosotros</h3>
                    <p>Desde diciembre del 2010, Seguros Americanos fue autorizada por la Superintendencia General de Seguros (SUGESE), cumpliendo con todos los requisitos legales y financieros de la Ley Reguladora del Mercado de Seguros para operar en Costa Rica, desde ese momento ha mantenido una posición de liderazgo en el mercado de seguros de personas.</p>
                    <p>Seguros Americanos continua con bases sólidas, su calificación de riesgo medida por la  Calificadora Fitch Rating es de AA-, destacando en su informe oficial factores claves como: perfil financiero intrínseco, el cual ha mostrado una evolución favorable registrando mejoras de manera sostenida en todas sus métricas durante los últimos 3 años, incremento en el capital, altos índices de desempeño y rentabilidad, niveles de siniestralidad sostenidamente bajos, eficiencia operativa, amplio conocimiento del negocio en Costa Rica y un programa de reaseguro sólido.La compañía se encuentra fortalecida por la  unión de dos importantes grupos con amplia experiencia y reconocimiento en el mercado nacional e internacional. Nuestros socios son: Compañía Internacional de Seguros (IS) y Cooperativa Nacional de Educadores (COOPENAE)”</p>
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

    <!-- team section -->
    <div id="team">
        <div class="container">
            <div class="row">
                <div class="col-md-12 col-sm-12">
                    <h2>Las personas detrás del exito</h2>
                </div>

                <div class="col-md-3 col-sm-6">
                    <img src="images/team1.jpg" class="img-responsive" alt="team img">
                    <h3>Luis Rosales</h3>
                    <h4>CEO-Cofundador</h4>
                </div>
                <div class="col-md-3 col-sm-6">
                    <img src="images/team2.jpg" class="img-responsive" alt="team img">
                    <h3>Alejandro Sanchez</h3>
                    <h4>Lider de proyectos</h4>
                </div>
                <div class="col-md-3 col-sm-6">
                    <img src="images/team3.jpg" class="img-responsive" alt="team img">
                    <h3>Jonathan Segura</h3>
                    <h4>Administrador de base de datos</h4>
                </div>
                <div class="col-md-3 col-sm-6">
                    <img src="images/team3.jpg" class="img-responsive" alt="team img">
                    <h3>Manuel Zarate</h3>
                    <h4>Desarrollador</h4>
                </div>

                <div class="col-md-3 col-sm-6">
                    <img src="images/team4.jpg" class="img-responsive" alt="team img">
                    <h3>Rosa Álvarez</h3>
                    <h4>Director Creativo</h4>
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

    <!-- portfolio section -->
    <!--<div id="portfolio">
        <div class="container">
            <div class="row">
                <div class="col-md-12 col-sm-12">
                    <div class="title">
                        <h2>Productos</h2>
                    </div>
                     ISO section
                    <div class="iso-section">
                        <ul class="filter-wrapper clearfix">
                             <li><a href="#" data-filter="*" class="selected opc-main-bg">All</a></li>
                             <li><a href="#" class="opc-main-bg" data-filter=".html">HTML</a></li>
                             <li><a href="#" class="opc-main-bg" data-filter=".photoshop">Photoshop</a></li>
                             <li><a href="#" class="opc-main-bg" data-filter=".wordpress">Wordpress</a></li>
                             <li><a href="#" class="opc-main-bg" data-filter=".mobile">Mobile</a></li>
                        </ul>
                        <div class="iso-box-section">
                            <div class="iso-box-wrapper col4-iso-box">

                                <div class="iso-box html photoshop wordpress mobile col-md-4 col-sm-6 col-xs-12">
                                    <a href="images/portfolio-img1.jpg" data-lightbox-gallery="portfolio-gallery"><img src="images/portfolio-img1.jpg" alt="portfolio img"></a>
                                 </div>

                                 <div class="iso-box html wordpress mobile col-md-4 col-sm-6 col-xs-12">
                                    <a href="images/portfolio-img2.jpg" data-lightbox-gallery="portfolio-gallery"><img src="images/portfolio-img2.jpg" alt="portfolio img"></a>
                                 </div>

                                 <div class="iso-box wordpress col-md-4 col-sm-6 col-xs-12">
                                    <a href="images/portfolio-img3.jpg" data-lightbox-gallery="portfolio-gallery"><img src="images/portfolio-img3.jpg" alt="portfolio img"></a>
                                 </div>

                                 <div class="iso-box html mobile col-md-6 col-sm-6 col-xs-12">
                                    <a href="images/portfolio-img4.jpg" data-lightbox-gallery="portfolio-gallery"><img src="images/portfolio-img4.jpg" alt="portfolio img"></a>
                                 </div>

                                 <div class="iso-box wordpress col-md-6 col-sm-6 col-xs-12">
                                    <a href="images/portfolio-img5.jpg" data-lightbox-gallery="portfolio-gallery"><img src="images/portfolio-img5.jpg" alt="portfolio img"></a>
                                 </div>

                                 <div class="iso-box html photoshop col-md-4 col-sm-6 col-xs-12">
                                    <a href="images/portfolio-img6.jpg" data-lightbox-gallery="portfolio-gallery"><img src="images/portfolio-img6.jpg" alt="portfolio img"></a>
                                 </div>

                                 <div class="iso-box photoshop col-md-4 col-sm-6 col-xs-12">
                                    <a href="images/portfolio-img7.jpg" data-lightbox-gallery="portfolio-gallery"><img src="images/portfolio-img7.jpg" alt="portfolio img"></a>
                                 </div>

                                 <div class="iso-box wordpress col-md-4 col-sm-6 col-xs-12">
                                    <a href="images/portfolio-img8.jpg" data-lightbox-gallery="portfolio-gallery"><img src="images/portfolio-img8.jpg" alt="portfolio img"></a>
                                 </div>

                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>-->
    <!-- divider section -->
    <!--<div class="container">
        <div class="row">
            <div class="col-md-1 col-sm-1"></div>
            <div class="col-md-10 col-sm-10">
                <hr>
            </div>
            <div class="col-md-1 col-sm-1"></div>
        </div>
    </div>-->
    <!-- pricing section -->
    <!--<div id="pricing">
        <div class="container">
            <div class="row">
                <div class="col-md-12 col-sm-12">
                    <h2>Our Pricing</h2>
                </div>
                <div class="col-md-4 col-sm-6 col-xs-10">
                    <div class="plan">
                        <div class="plan-title">
                            <h3>Starter</h3>
                            <small>$100 per month</small>
                        </div>
                        <ul>
                            <li>100 GB STORAGE</li>
                            <li>10 TB BANDWIDTH</li>
                            <li>10 BASIC THEMES</li>
                            <li>24-HOUR RESPONSE</li>
                        </ul>
                        <button class="btn btn-warning">Sign Up</button>
                    </div>
                </div>
                <div class="col-md-4 col-sm-6 col-xs-10">
                    <div class="plan">
                        <div class="plan-title">
                            <h3>Business</h3>
                            <small>$350 per month</small>
                        </div>
                        <ul>
                            <li>1,000 GB STORAGE</li>
                            <li>50 TB BANDWIDTH</li>
                            <li>50 PRO THEMES</li>
                            <li>1-HOUR RESPONSE</li>
                        </ul>
                        <button class="btn btn-warning">Sign Up</button>
                    </div>
                </div>
                <div class="col-md-4 col-sm-6 col-xs-10">
                    <div class="plan">
                        <div class="plan-title">
                            <h3>Advanced</h3>
                            <small>$500 per month</small>
                        </div>
                        <ul>
                            <li>2,000 GB STORAGE</li>
                            <li>100 TB BANDWIDTH</li>
                            <li>100 PREMIUM THEMES</li>
                            <li>30-MIN RESPONSE</li>
                        </ul>
                        <button class="btn btn-warning">Sign Up</button>
                    </div>
                </div>
            </div>
        </div>
    </div>-->
    <!-- divider section -->
    <!--<div class="container">
        <div class="row">
            <div class="col-md-1 col-sm-1"></div>
            <div class="col-md-10 col-sm-10">
                <hr>
            </div>
            <div class="col-md-1 col-sm-1"></div>
        </div>
    </div>-->
    <!-- contact section -->
    <!--<div id="contact">
        <div class="container">
            <div class="row">
                <div class="col-md-12 col-sm-12">
                    <h2>Keep in touch</h2>
                </div>
                <form action="#" method="post" role="form">
                    <div class="col-md-1 col-sm-1"></div>
                    <div class="col-md-10 col-sm-10">
                        <div class="col-md-6 col-sm-6">
                            <input name="name" type="text" class="form-control" id="name" placeholder="Name">
                        </div>
                        <div class="col-md-6 col-sm-6">
                            <input name="email" type="email" class="form-control" id="email" placeholder="Email">
                        </div>
                        <div class="col-md-12 col-sm-12">
                            <input name="subject" type="text" class="form-control" id="subject" placeholder="Subject">
                        </div>
                        <div class="col-md-12 col-sm-12">
                            <textarea name="message" rows="5" class="form-control" id="message" placeholder="Message"></textarea>
                        </div>
                        <div class="col-md-8 col-sm-8">
                            <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy</p>
                        </div>
                        <div class="col-md-4 col-sm-4">
                            <input name="submit" type="submit" class="form-control" id="submit" value="SEND MESSAGE">
                        </div>
                    </div>
                    <div class="col-md-1 col-sm-1"></div>
                </form>
            </div>
        </div>
    </div>-->
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
                    <p>Email: <span>info@segurosamericanos.com</span></p>
                    <p>Tel: <span>2256-9078</span></p>
                </div>
                <div class="col-md-6 col-sm-6">
                    <h2>Redes Sociales</h2>
                    <ul class="social-icons">
                        <li><a href="#" class="fa fa-facebook"></a></li>
                        <li><a href="#" class="fa fa-twitter"></a></li>
                        <li><a href="#" class="fa fa-google-plus"></a></li>
                        <li><a href="#" class="fa fa-dribbble"></a></li>
                    </ul>
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
                    <p>
                        Copyright &copy; 2016 SegurosAmericanos

                        - Design: <a rel="nofollow" href="http://www.uam.ac.cr" target="_parent">Proyecto_Progra4</a>
                    </p>
                </div>
            </div>
        </div>
    </div>

    <!-- scrolltop section -->
    <a href="#top" class="go-top"><i class="fa fa-angle-up"></i></a>

</asp:Content>
