<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SistemasDeDatos.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div class="container">
<h3>Cargas</h3>
<div class="list-group">
 <%--<a href="Carga/CargaCompras" class="list-group-item">Compras.</a>--%>
 <a href="Cargas/NuevoProducto" class="list-group-item">Productos.</a>
 <a href="Cargas/NuevoProveedor" class="list-group-item">Proveedor.</a>
 <a href="Cargas/NuevoRubro" class="list-group-item">Rubros.</a>
 <a href="Cargas/NuevoVendedor" class="list-group-item">Vendedor.</a>
 <a href="Cargas/CargaVentas" class="list-group-item">Ventas.</a>	
</div>
</div>

</asp:Content>
