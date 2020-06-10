<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="SistemasDeDatos.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Prueba de Consultas.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="Consultar" OnClick="Button2_Click" />
    </h3>
    <p>
        <asp:Label ID="Consulta" runat="server" Text=""></asp:Label>
    </p>
</asp:Content>
