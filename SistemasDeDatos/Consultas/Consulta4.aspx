<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consulta4.aspx.cs" Inherits="SistemasDeDatos.Consultas.Consulta4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
              <p>
        <br />
    </p>
    <div>
          <a runat="server" href="~/About">Volver</a>

    </div>
        <hr />
        <div style="height: 286px">
            <table border="2" class="table table-dark">
                <tr>
                    <td>Nombre</td>
                    <td>Precio</td>
                    <td>Cantidad</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Nombre" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Precio" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Cantidad" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
          </div>
</div>
</asp:Content>
