<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consulta6.aspx.cs" Inherits="SistemasDeDatos.Consultas.Consulta6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
         <p>
        <br />
    </p>
    <div>
   <a runat="server" href="~/About">Volver</a>

    </div>
        <hr />
        <div style="height: 655px">
            <table class="table table-dark" border="2">
                <tr>
                    <td style="width: 121px; height: 37px;">Nombre Vendedor</td>
                    <td style="width: 130px; height: 37px;">Apellido</td>
                    <td style="width: 338px; height: 37px;">Producto</td>
                    <td style="width: 88px; height: 37px;">Cantidad</td>
                    <td style="height: 37px">Total</td>
                </tr>
                <tr>
                    <td style="width: 121px">
                        <asp:Label ID="Nombre" runat="server" Text=""></asp:Label>
                    </td>
                    <td style="width: 130px">
                        <asp:Label ID="Apellido" runat="server" Text=""></asp:Label>
                    </td>
                    <td style="width: 338px">
                        <asp:Label ID="Producto" runat="server" Text=""></asp:Label>
                    </td>
                    <td style="width: 88px">
                        <asp:Label ID="Cantidad" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Total" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
          </div>
</div>
</asp:Content>
