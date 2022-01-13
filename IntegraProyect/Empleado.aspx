<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleado.aspx.cs" Inherits="IntegraProyect.Empleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">


.lead {
  margin-bottom: 20px;
  font-size: 16.099999999999998px;
  font-weight: 200;
  line-height: 1.4;
}

  .lead {
    font-size: 21px;
  }

  * {
    color: #000 !important;
    text-shadow: none !important;
    background: transparent !important;
    box-shadow: none !important;
  }
    
* {
  -webkit-box-sizing: border-box;
     -moz-box-sizing: border-box;
          box-sizing: border-box;
}

        .auto-style1 {
            margin-left: 0;
            margin-right: 0;
            margin-top: 0;
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        REGISTROS DE EMPLEADO<br />
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="85px" Width="111px" />
    
    </div>
        <p>
&nbsp;ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="225px"></asp:TextBox>
        </p>
        <p class="auto-style1" style="orphans: 3; widows: 3;">Apellido&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server" Width="232px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
        </p>
        <p class="auto-style1" style="orphans: 3; widows: 3">
            Nombre&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="231px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
        </p>
        <p class="auto-style1" style="orphans: 3; widows: 3">
            Telefono&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Width="231px"></asp:TextBox>
&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="Formato Requerido (xxx)-xxx-xxx" ValidationExpression="((\(\d{3}\) ?)|(\d{3}))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
        </p>
        <p class="auto-style1" style="orphans: 3; widows: 3">
            Correo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="227px"></asp:TextBox>
        </p>
        <p class="auto-style1" style="orphans: 3; widows: 3">
            Foto&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </p>
        <p class="auto-style1" style="orphans: 3; widows: 3">
            Fecha&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" Width="224px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox6" ErrorMessage="Formato Requerido MM/DD/AAAA" ValidationExpression="^(?:0?[1-9]|1[1-2-0])([\-/.])(3[01]|[12][0-9]|0?[1-9])\1\d{4}$"></asp:RegularExpressionValidator>
        </p>
        <p class="auto-style1" style="orphans: 3; widows: 3">
&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Nuevo" Width="85px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="height: 26px" Text="Agregar" Width="83px" />
&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Modificar" Width="80px" />
&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Eliminar" Width="77px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Ficha Empleado" />
        </p>
        <p class="auto-style1" style="orphans: 3; widows: 3">
            Buscar por Nombre o Apellido&nbsp;
            <asp:TextBox ID="TextBox7" runat="server" Width="197px"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Buscar Empleado" />
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Pagina Principal</asp:HyperLink>
        </p>
        <p class="auto-style1" style="orphans: 3; widows: 3">
            &nbsp;</p>
        <p class="auto-style1" style="orphans: 3; widows: 3">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
