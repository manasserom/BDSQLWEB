<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consulta2.aspx.cs" Inherits="SistemasDeDatos.Consultas.Consulta2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
          <p>
        <br />
    </p>
    <div>
          <a runat="server" href="~/About">Volver</a>
    </div>
        <hr />
        <div style="height: 264px">
            <asp:Label ID="Label1" runat="server" Text="Muestra Vendedores"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <table class="table table-dark" border="2">
                <tr>
                    <td>Nombre</td>
                    <td>Apellido</td>
                    <td>D.N.I</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Nombre" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Apellido" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Dni" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
          </div>
         </div> 
</asp:Content>
