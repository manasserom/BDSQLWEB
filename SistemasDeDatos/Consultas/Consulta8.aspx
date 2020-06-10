<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consulta8.aspx.cs" Inherits="SistemasDeDatos.Consultas.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <hr />
    <div>
     <a runat="server" href="~/About">Volver</a>   
    </div>
    <hr />
    <div style="height: 542px">

        <table class="table table-dark" border="2">
            <tr>
                <td style="width: 393px" class="modal-sm">Nombre de Proveedor</td>
                <td>Nombre de Rubro</td>
            </tr>
            <tr>
                <td style="width: 393px; height: 20px;">
                    <asp:Label ID="NProveedor" runat="server" Text=""></asp:Label>
                </td>
                <td style="height: 20px">
                    <asp:Label ID="NRubro" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
