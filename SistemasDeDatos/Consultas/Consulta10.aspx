<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consulta10.aspx.cs" Inherits="SistemasDeDatos.Consultas.Consulta10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <a runat="server" href="~/About">Volver</a>
    </div>
    
    <hr />
    <div style="height: 279px">
        <asp:Label ID="Label4" runat="server" Text="Ingrese el nombre del producto"></asp:Label>
        <asp:TextBox ID="Nombre" class="form-control" runat="server" Width="377px"></asp:TextBox>
        <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="Buscar" OnClick="Button1_Click" />

        <table class="table table-dark" style="width: 94%" border="2">
            <tr>
                <td style="height: 20px; width: 550px">Nombre</td>
                <td style="height: 20px; width: 99px">Cantidad</td>
                <td style="height: 20px">Precio</td>
            </tr>
            <tr>
                <td style="width: 550px">
                    <asp:Label ID="NProducto" runat="server" Text=""></asp:Label>
                </td>
                <td class="modal-sm" style="width: 99px">
                    <asp:Label ID="CProducto" runat="server" Text=""></asp:Label>
                </td>
                <td>
                    <asp:Label ID="PProducto" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
