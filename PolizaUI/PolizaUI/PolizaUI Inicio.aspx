﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PolizaUIMaster.Master" AutoEventWireup="true" CodeBehind="PolizaUI Inicio.aspx.cs" Inherits="PolizaUI.PolizaUI_Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="H1Global">Bienvenido</h1>
    <div id="wowslider-container1">
	<div class="ws_images"><ul>
		<li><img src="Resources/Slider/data1/images/proto1.jpg" alt="Proto1" title="Proto1" id="wows1_0"/></li>
		<li><a href=""><img src="Resources/Slider/data1/images/proto2.jpg" alt="bootstrap carousel example" title="Proto2" id="wows1_1"/></a></li>
		<li><img src="Resources/Slider/data1/images/proto3.jpg" alt="Proto3" title="Proto3" id="wows1_2"/></li>
	</ul></div>
	<div class="ws_bullets"><div>
		<a href="#" title="Proto1"><span><img src="Resources/Slider/data1/tooltips/proto1.jpg" alt=""/>1</span></a>
		<a href="#" title="Proto2"><span><img src="Resources/Slider/data1/tooltips/proto2.jpg" alt=""/>2</span></a>
		<a href="#" title="Proto3"><span><img src="Resources/Slider/data1/tooltips/proto3.jpg" alt=""/>3</span></a>
	</div></div><div class="ws_script" style="position:absolute;left:-99%"><a href="http://wowslider.net">html slider</a> by WOWSlider.com v8.8</div>
	<div class="ws_shadow"></div>
	</div>	
    <!---Comienza texto de polizas-->
    <Br />
    


    <h4>Fecha</h4>
<input type="text" runat="server" name="Hola" id="inputExample" onkeypress="return SoloLetras(event)" class="Inputs-Margin" placeholder="_-____-____" data-mask="00/00/0000" required/>
    <br />
    <h4>Nombre</h4>
<input type="text" runat="server" name="Hola" id="Text1" onkeypress="return SoloLetras(event)" class="Inputs-Margin" required/>
    <br />
    <h4>Apellido</h4>
<input type="text" runat="server" name="Hola" id="Text2" onkeypress="return SoloLetras(event)" class="Inputs-Margin" required/>
    <br />
    <h4>Cedula</h4>
<input type="text" runat="server" name="Hola" id="Text3" onkeypress="return SoloLetras(event)" class="Inputs-Margin" required/>
    <br />
  <h4>Genero</h4>  
<input type="text" runat="server" name="Hola" id="Text4" onkeypress="return SoloLetras(event)" class="Inputs-Margin" required/>
    <br />
    <br />
    <br />
    <br />
<input type="submit" runat="server" id="btnExample" />
</asp:Content>
