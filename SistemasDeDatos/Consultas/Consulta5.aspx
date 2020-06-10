<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consulta5.aspx.cs" Inherits="SistemasDeDatos.Consultas.Consulta5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
                  <p>
        <br />
    </p>
    <div>
         <a runat="server" href="~/About">Volver</a>

    </div>
        <hr />
        <div style="height: 414px">
            <table class="table table-dark" border="2">
                <tr>
                    <td>Producto</td>
                    <td>Proveedor</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Producto" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Proveedor" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
          </div>
</div>
</asp:Content>
