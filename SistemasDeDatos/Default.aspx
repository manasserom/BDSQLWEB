<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SistemasDeDatos._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div class="jumbotron" style="background: linear-gradient(to right, #36a57a,#434ca9);">
        <h1 class="">Sistemas de Datos</h1>
        <p class="lead"><strong>TALLER:</strong> Diseño y Construcciíon de Base de Datos.</p>
        <p class="pull-right text-white">-2019-</p>
    </div>

    <div class="row ">
        <div class="col-md-3 ">
            <h2>Docentes:</h2>
            <p>
                Mag. María Alejandra Malberti.<br />
           Lic. Ariana Martín.<br />
           Lic. Laura Gutierrez.

            </p>
        </div>
        <div class="col-md-3">
            <h2>Alumnos:</h2>
            <p>
                Aballay, Rodrigo.<br />
                Drazic, Leandro.<br />
                Manassero, Martin.

            </p>
        </div>
        <div class="col-md-6">
            <h2>Narrativa:</h2>
            <p>
                Una importante Ferretería  desea llevar un control sobre los movimientos financieros y materiales. Para ellos se decide emplear una base de datos que contenga toda la información sobre los Proveedores, vendedores, productos, ventas y compras.
            </p>
        </div>
    </div>

</asp:Content>
