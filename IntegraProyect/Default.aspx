<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>INTEGRA</h1>
        <p class="lead">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Empleado.aspx">Registro de Empleados</asp:HyperLink>
        </p>
        <p class="lead">
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Graf1.html">Grafico url JSON</asp:HyperLink>
        </p>
        <p>&nbsp;</p>
    </div>
   
    
    
    <div class="row">
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
    </div>
</asp:Content>
