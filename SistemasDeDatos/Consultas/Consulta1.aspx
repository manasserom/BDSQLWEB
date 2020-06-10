<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consulta1.aspx.cs" Inherits="SistemasDeDatos.Consultas.Consulta1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
         <p>
        <br />
    </p>
    <div>
          <a runat="server" href="~/About">Volver</a>

    </div>
        <hr />
        <div style="height: 264px">
            <asp:Label ID="Label1" runat="server" Text="Muestra Proveedores"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <table class="table table-dark" border="2">
                <tr>
                    <td style="width: 443px">Nombre :</td>
                    <td>Cuit</td>
                </tr>
                <tr>
                    <td style="width: 443px">
                        <asp:Label ID="Nombre" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Cuit" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
          </div>
         </div> 





</asp:Content>
