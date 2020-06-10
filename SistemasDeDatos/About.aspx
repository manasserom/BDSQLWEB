<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="SistemasDeDatos.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
<h3>Consultas</h3>
<div class="list-group">
 <a href="Consultas/Consulta1" class="list-group-item">Listar los datos de los Proveedores.</a>
 <a href="Consultas/Consulta2" class="list-group-item">Listar los datos de los Vendedores.</a>
 <a href="Consultas/Consulta3" class="list-group-item">Listar los datos de los Productos.</a>	
 <a href="Consultas/Consulta4" class="list-group-item">Listar los productos sin stock (cantidad igual a 0).</a>
 <a href="Consultas/Consulta5" class="list-group-item">Mostrar a qué proveedor fue comprado cada producto.</a>
 <a href="Consultas/Consulta6" class="list-group-item">Listar las ventas y los datos del vendedor que la realizó.</a>
 <a href="Consultas/Consulta7" class="list-group-item">Dado un vendedor, mostrar la información de sus ventas.</a>
 <a href="Consultas/Consulta8" class="list-group-item">Mostrar los rubros a los se dedican los proveedores.</a>
 <a href="Consultas/Consulta9" class="list-group-item">Mostrar los rubros que un vendedor NO ha vendido.</a>
 <a href="Consultas/Consulta10" class="list-group-item">Dado un nombre de un producto , mostrar los datos <strong>solo </strong>sí pertenece a todos los rubros.</a>
 <a href="Consultas/Consulta11" class="list-group-item">Mostrar los nombres de proveedores a los que se les han comprado todos los productos alguna vez.</a>
</div>
</div>
</asp:Content>
