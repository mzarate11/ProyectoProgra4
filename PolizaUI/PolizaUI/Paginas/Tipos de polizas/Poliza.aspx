<%@ Page Title="" Language="C#" MasterPageFile="~/PolizaUIMaster.Master" AutoEventWireup="true" CodeBehind="Poliza.aspx.cs" Inherits="PolizaUI.Paginas.Persona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="content-type" content="text/html"; charset="utf-8"/>
    <title>Login</title>
    <link rel="stylesheet" href="Resources/bootstrap.min.css"/>
    <link rel="stylesheet" href="../../styles/Login.css"/>
    <script type="text/javascript" src="../../Resources/jquery.min.js"></script>
    <script type="text/javascript" src="../../Resources/bootstrap.min.js" ></script>
    <script type="text/javascript" src="../../Scripts/Login.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <form>
            <div id="h">
                <h1 class="H1Global"></h1>
            </div>
  <div class="form-group">
   <%--<asp:DropDownList style="background-color:#104b59;" runat="server" class="btn btn-primary dropdown-toggle">
      <asp:listitem text="Tipo Poliza :" value="0"></asp:listitem>
      <asp:listitem text="Póliza Colectiva de Vida." value="1"></asp:listitem>
      <asp:listitem text="Póliza de Seguro Médico Básico." value="2"></asp:listitem>
      <asp:listitem text="Seguro Grupal de Responsabilidad Civil Profesional." value="3"></asp:listitem>
      <asp:listitem text="Póliza de Seguro Médico Básico." value="4"></asp:listitem>
      <asp:listitem text="Pólizas de Seguros Médicos Voluntarios." value="5"></asp:listitem>
      <asp:listitem text="Póliza de Seguro de Vida 01-16VIC-299." value="6"></asp:listitem>
      <asp:listitem text="Procedimiento para la presentación de reclamos y Solicitud de Beneficios." value="7"></asp:listitem>
      <asp:listitem text="Médicos Pensionados." value="8"></asp:listitem>
      <asp:listitem text="Seguro de Asistencia al Viajero." value="9"></asp:listitem>
      
  </asp:DropDownList>--%>


      <div class="container">
  <h2>Polizas</h2>
  <p>Las siguentes son <strong>nuestras polizas de seguros. </strong><br />Por favor sienta se llibre de mirar nuestras polizas.</p>
  <div class="panel-group" id="accordion">
    <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#collapse1"> <strong> Póliza Colectiva de Vida.</strong></a>
        </h4>
      </div>
      <div id="collapse1" class="panel-collapse collapse in">
        <div class="panel-body">Estas pólizas de Vida incluyen un monto fijo destinado a garantizar el patrimonio familiar 
            por el fallecimiento, desmembramiento o incapacidad del empleado asegurado, ofreciendo así indemnización a los 
            beneficiarios del asegurado ante la ocurrencia de uno de los eventos amparados en el seguro.</div>
      </div>
    </div>
    <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#collapse2"><strong> Póliza de Seguro Médico Básico.</strong></a>
        </h4>
      </div>
      <div id="collapse2" class="panel-collapse collapse">
        <div class="panel-body"> La póliza contiene un paquete de beneficios médicos, tal como pruebas, 
            medicamentos y servicios de tratamiento. La compañía de seguros acepta cubrir el costo de ciertos beneficios establecidos 
            en su póliza.</div>
      </div>
    </div>
    

      <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#collapse3"><strong> Seguro Grupal de Responsabilidad Civil Profesional.</strong></a>
        </h4>
      </div>
      <div id="collapse3" class="panel-collapse collapse">
        <div class="panel-body">El objetivo de los seguros de Responsabilidad Civil Profesional es hacer frente a los daños
    personales, materiales y consecuenciales que, involuntariamente, por sus errores u omisiones,
    el profesional haya podido causar a sus clientes en el ejercicio de su profesión, así como los
    perjuicios que de ellos se pudieran derivar. El nosotros como aseguradora asumiremos las consecuencias
    económicas de los hechos acaecidos y cubiertos por el contrato, reparando el daño causado
    por el asegurado a un tercero, hasta el límite pactado en la póliza de seguro, que es el
    documento que contiene las condiciones que regulan la relación contractual entre nosotros y
    asegurados o sea ustedes, recogiendo los derechos y deberes de las partes.</div>
      </div>
    </div>

      <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#collapse4"><strong> Pólizas de Seguros Médicos Voluntarios.</strong></a>
        </h4>
      </div>
      <div id="collapse4" class="panel-collapse collapse">
        <div class="panel-body">Nosotors como aseguradora tenemos el tabajo de tambien trabajar por esas personas con capacidad contributiva no obligadas a cotizar,
        que se afilian voluntariamente para tener un seguro medico a la altura de lo que contribuyen.</div>
      </div>
    </div>
      <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#collapse5"><strong> Póliza de Seguro de Vida 01-16VIC-299.</strong></a>
        </h4>
      </div>
      <div id="collapse5" class="panel-collapse collapse">
        <div class="panel-body">





        </div>
      </div>
    </div>

      <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#collapse6"><strong> Procedimiento para la presentación de reclamos y Solicitud de Beneficios.</strong></a>
        </h4>
      </div>
      <div id="collapse6" class="panel-collapse collapse">
        <div class="panel-body">Todos los colegiados, sin distingo de edad, son sujetos de estos beneficios en el tanto se encuentren al día en el pago de la colegiatura al
        momento de suceder los eventos médicos. Si no se encontrare al día con sus cuotas, pero el adeudo no es mayor de 3 cuotas al
        momento del evento médico, deberá cancelar las cuotas pendientes de inmediato y podrá presentar el reclamo correspondiente. Si el
        adeudo es superior a cinco cuotas el reclamo no procederá. La póliza cubre únicamente al colegiado/a y SE PAGA POR REEMBOLSO.

        Si el colegiado adeuda más de cinco cuotas, reingresará automáticamente a la póliza, una vez que regularice el pago de sus obligaciones
        para con el Colegio. En estos casos de re-inclusión, empezaran a regir nuevamente las cláusulas restrictivas de primer año y preexistencia
        establecidas en el Contrato Póliza.

     A los colegiados que se incorporen o reincorporen al Colegio, el beneficio regirá con vigencia a partir del primer día del mes siguiente al
        mes de incorporación o reincorporación. Ejemplo: se incorpora el 23 de mayo; la pòliza aplica a partir del 01 de junio.</div>
      </div>
    </div>


      <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#collapse7"><strong> Médicos Pensionados.</strong></a>
        </h4>
      </div>
      <div id="collapse7" class="panel-collapse collapse">
        <div class="panel-body">Los médicos que se pensionan, o que cumplen 65 años, deben hacer la respectiva
            gestión ante la Plataforma de Servicios y la UNIDAD DE SEGUROS del Colegio de
            Médicos, para que puedan continuar con la cobertura de su seguro médico y que 
            puedan seguir disfrutando de la cobertura, mediante el pago de la cuota mensual de
            seguro correspondiente.
            Si el médico no hace esta gestión, el Colegio lo excluye de la póliza, y si
            posteriormente el médico desea contar con el seguro, debe solicitar su inclusión y
            comenzar a realizar los pagos correspondientes.
.</div>
      </div>
    </div>


      <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#collapse8"><strong> Seguro de Asistencia al Viajero.</strong></a>
        </h4>
      </div>
      <div id="collapse8" class="panel-collapse collapse">
        <div class="panel-body">Viaje con mayor tranquilidad, ya sea en el país o en el exterior, por trabajo o placer, relájese sabiendo que durante su estadía estará protegido ante cualquier eventualidad con nuestro Seguro de Viajero.

Y es que por lo general, cuando planificamos un viaje en lo que menos pensamos es en los riesgos que podemos correr. 
            Sin embargo, nadie está exento de vivir una situación que termine con sus deseadas vacaciones o que trunque su trabajo.
            El Seguro Viajero en colones le cubre las 24 horas del día, en cualquier parte del mundo. Usted puede suscribirlo si viaja como mínimo  
            por una semana o  hasta cincuenta y dos (52) semanas máximo.

            Esta póliza no tiene edad mínima ni máxima de suscripción. El precio varía en función del rango de edad 
            en que se encuentre la persona que desea el seguro, la cantidad de días que va a viajar y la opción de monto 
            asegurada escogida. Los rangos de edades son de 0 a 18 años, de 19 a 45 años, de 46 a 70 años, de 71 a 80 años  y de más de 80 años.
        </div>
      </div>
    </div>

      <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#collapse9"><strong> Póliza Colectiva de Vida.</strong></a>
        </h4>
      </div>
      <div id="collapse9" class="panel-collapse collapse">
        <div class="panel-body">Las pólizas colectivas consisten en un solo y único contrato un grupo de personas se aseguran en condiciones más beneficiosas que si lo hicieran individualmente. Las pólizas colectivas cubren en forma independiente a un número de personas dentro de la misma póliza.
            Así, ponemos a su disposición el Seguro Vida Tradicional Colectiva Colones y Vida Tradicional Colectiva Dólares.
            La protección se brinda través del que gestiona el seguro, quien negocia con el INS las condiciones de aseguramiento
             para el grupo.
            Segmentación de Grupo

            Se establecen los siguientes segmentos de mercado:
            Grupo Natural: Integrado por los grupos de empleados que pertenecen a un mismo patrono (obrero-patronal) 
            y los grupos que se derivan de un grupo obrero patronal.
            Otros Grupos: Integrados por grupos que no se derivan de un mismo patrono como colegios profesionales, 
            asociaciones, cámaras, cooperativas y además, las operadoras de pensiones.</div>
      </div>
    </div>
       <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#collapse10"><strong> Formularios del Seguro Básico del Colegio de Médicos.</strong></a>
        </h4>
      </div>
      <div id="collapse10" class="panel-collapse collapse">
        <div class="panel-body">Es un plan de medicina prepagada. Con su afiliación de $12* al
             mes por el titular y $6*al mes por cada beneficiario, usted tendrá acceso a beneficios de 
            hasta un 80% en más de 45 especialidades médicas y en más de 500 servicios médicos</div>
      </div>
    </div>
      <br />    
      <div class="row">
     <p class="col-6"><input type="button" runat="server" value="Inicio" class="btn btn-primary dropdown-toggle" id="btn_A" href="PolizaUI Inicio.aspx"/>
     
         
  <p>Para más informacion puede llamarnos al : <strong> 2888-1111 o al 8107-3333</strong><br /> Si aún ocupa mas información no dude en acercarsenos en la Avenida 4, Costa Rica, San José, San Pedro.</p>
</div>

  </div> 


</div>

  </div>

</form>
    </div>
                            
                       

                            
                       
</asp:Content>