<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consulta11.aspx.cs" Inherits="SistemasDeDatos.Consultas.Consulta11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div>
        <a runat="server" href="~/About">Volver</a>
    </div>
    <hr />
    <div style="height: 192px">

        <table class="table table-dark" border="2">
            <tr>
                <td>Nombre de Proveedor</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="NProveedor" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
