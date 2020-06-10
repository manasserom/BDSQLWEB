<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoVendedor.aspx.cs" Inherits="SistemasDeDatos.Cargas.NuevoProveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <div>
           <a runat="server" href="~/Contact">Volver</a>
    </div>
        <hr />
        <div style="height: 367px; margin-left: 200px;">
            <asp:Label ID="Label1" runat="server" Text="Nombre del Nuevo Vendedor"></asp:Label>
            <asp:TextBox ID="Nombre" class="form-control" runat="server" Width="339px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server"  Text="Apellido del Nuevo Vendedor"></asp:Label>
            <asp:TextBox ID="Apellido" class="form-control" runat="server" Width="341px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="D.N.I del Nuevo Vendedor"></asp:Label>
            <asp:TextBox ID="DNI" class="form-control" runat="server" Width="343px"></asp:TextBox>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button8" runat="server" cssClass="btn btn-success" Text="Cargar" OnClick="Button8_Click" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Mensaje" runat="server" Text=""></asp:Label>
          </div>
</div>
</asp:Content>
