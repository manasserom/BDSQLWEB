<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoProveedor.aspx.cs" Inherits="SistemasDeDatos.Cargas.NuevoVendedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <div>
           <a runat="server" href="~/Contact">Volver</a>
    </div>
        <hr />
        <div style="height: 282px; margin-left: 240px;">
            <asp:Label ID="Label1" runat="server" Text="Nombre de Proveedor"></asp:Label>
            <asp:TextBox ID="Nombre" class="form-control" runat="server" Width="384px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="C.U.I.T de Proveedor"></asp:Label>
            <asp:TextBox ID="cuit" class="form-control" runat="server" Width="387px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button8" class="btn btn-success" runat="server" Text="Cargar" OnClick="Button8_Click" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Mensaje" runat="server" Text=""></asp:Label>
          </div>
    </div>
</asp:Content>
