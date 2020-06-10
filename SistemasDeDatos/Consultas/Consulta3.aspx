<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consulta3.aspx.cs" Inherits="SistemasDeDatos.Consultas.Consulta3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <div>
          <a runat="server" href="~/About">Volver</a>

    </div>
        <hr />
        <div style="height: 665px">
            <table class="table table-dark" border="2">
                <tr>
                    <td>Nombre - Descripción</td>
                    <td>Precio</td>
                    <td>Cantidad</td>
                </tr>
                <tr>
                    <td style="height: 20px">
                        <asp:Label ID="Nombre" runat="server" Text=""></asp:Label>
                    </td>
                    <td style="height: 20px">
                        <asp:Label ID="Precio" runat="server" Text=""></asp:Label>
                    </td>
                    <td style="height: 20px">
                        <asp:Label ID="Cantidad" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
          </div>
</div>
</asp:Content>
